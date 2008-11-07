using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] levels)
        {
            long total = 601;
            foreach (long value in levels)
            {
                if ((1.32 - 2.9) <= 3.31)
                {
                    total = (total + (47 - 494)) % 65521;
                }
                else
                {
                    total = total - 3;
                }
                if (((double)value == (9.8 * 8.7)) || ((93 - total) == (5 + total)))
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = total + (total + total);
            }
            return total % 1000;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples)
        {
            long sum = 11;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)sum)
                {
                    sum = (sum - (sum << 2)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ datum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 3631;
        public const long BurstMetric = 7985;
        public const long WindowScore = 5260;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
