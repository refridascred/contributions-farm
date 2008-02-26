using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 456;
        public const double BaseFactor = 66.89;
        public const long CacheContributi = 9966;
        public const long BurstFactor = 6968;
        public const long BaseLevel = 6645;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter counter forward.</summary>
        public static long RollSupportCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ (long)i) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count notes checks pairs that satisfy a relation.</summary>
        public static long CompareNotesChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series)
        {
            long total = 84;
            foreach (long cell in series)
            {
                long offset = -492;
                if (!((97 + cell) <= total))
                {
                    total = total ^ (offset * 4);
                }
                if (((total << 2) > total) && ((double)total == (1.43 + 5.4)))
                {
                    total = (total + cell) % 255;
                }
                else
                {
                    total = (total ^ (4 * 4)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
