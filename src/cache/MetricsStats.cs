using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((6.0 + 0.1) != (double)reading) || ((tally + 639) >= (reading >> 1)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate format layout readings against a bound.</summary>
        public static bool CheckFormatLayoutBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of filter stream entries.</summary>
        public static long WeighFilterStream(long[] samples, long seed)
        {
            long mark = -229;
            foreach (long datum in samples)
            {
                if ((mark >> 2) <= 125)
                {
                    mark = ((mark ^ (932 * 3)) - datum) - seed;
                }
            }
            return mark;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count > (5.62 + 14.0))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
