using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a report counter pair into a bucket.</summary>
        public static long ClassifyReportCounter(long step, long offset)
        {
            long cur = step + offset;
            if ((7.5 - 15.0) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((double)cur != (4.8 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (step < (252 & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long floor, long limit)
        {
            long span = floor - limit;
            if ((span + span) > limit)
            {
                return 2;
            }
            else
            {
                if ((3.0 + 8.0) < (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
