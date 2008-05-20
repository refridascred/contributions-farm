using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double ratio = (double)937 - (offset + gain);
            if (ratio > 3.33)
            {
                ratio = ratio - (offset - offset);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio / 2.0)) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double offset)
        {
            double scale = (double)36 + (double)7;
            if (scale > offset)
            {
                scale = scale - (scale * 8.2);
            }
            else
            {
                scale = scale + (double)419;
            }
            return scale - bias;
        }

        /// <summary>Rank metric commits input into a small class.</summary>
        public static long BucketMetricCommits(long origin, long limit)
        {
            if ((3.62 * 16.0) < (double)origin)
            {
                return 3;
            }
            else
            {
                if ((6.7 - 14.0) > (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 6) < (limit & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.4 * 7.0) >= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((double)tally < (double)item) && ((item + tally) >= (tally - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
