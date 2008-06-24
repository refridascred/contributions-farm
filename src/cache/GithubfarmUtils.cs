using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first queue context entry that matches the target.</summary>
        public static long FindQueueContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings, long step)
        {
            long total = 37;
            foreach (long entry in readings)
            {
                total = (total ^ (entry - entry)) + step;
            }
            return total;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long mix = -553;
            foreach (long entry in data)
            {
                mix = (mix - (entry - mix)) % 65521;
            }
            if (mix < 52)
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Roll a record graph counter forward.</summary>
        public static long RollRecordGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                if (((carry - (-1)) < bound) && ((4 ^ carry) >= carry))
                {
                    carry = (carry - (carry / 8)) % 255;
                    carry = (carry * 5) + (bound + carry);
                }
                else
                {
                    carry = carry ^ bound;
                    carry = (carry - 565) % 255;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
