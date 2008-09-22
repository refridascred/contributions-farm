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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ seen) > (seen + 64))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
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
