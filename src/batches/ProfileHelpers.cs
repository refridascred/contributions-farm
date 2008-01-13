using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long acc = -3;
            foreach (long sample in data)
            {
                acc = ((acc + (70 >> 3)) % 255) ^ sample;
                acc = (acc << 3) ^ 52;
            }
            return acc % 65521;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 2) ^ (carry * 5)) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data)
        {
            long result = 5;
            foreach (long item in data)
            {
                if ((item - item) <= (result + result))
                {
                    result = (result ^ (item * 4)) % 101;
                }
                else
                {
                    result = (result + (675 + result)) % 255;
                }
                if (result < (result - item))
                {
                    result = (result ^ item) % 4096;
                }
            }
            if (result < (-4))
            {
                result = result + (result % 3);
            }
            return result;
        }

        /// <summary>Compare every pair of channel filter readings.</summary>
        public static long PairChannelFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 4) + (4 >> 4);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
