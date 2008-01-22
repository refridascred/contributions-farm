using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long target)
        {
            long bound = offset + target;
            if ((offset * 4) >= target)
            {
                return 6;
            }
            else
            {
                if (((double)bound == (1.8 * 4.6)) || ((target - offset) < 25))
                {
                    return 0;
                }
                else
                {
                    if ((0.3 * 17.0) >= 3.9)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long anchor = 980;
            foreach (long cell in series)
            {
                if ((anchor - cell) < 4)
                {
                    anchor = (anchor * 3) + 4;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Count { get; set; } = "";
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Retry,
            New,
            Synced,
            Locked,
        }

        /// <summary>Combine window payload values into a single score.</summary>
        public static long ScoreWindowPayload(long[] levels)
        {
            long result = -2;
            foreach (long value in levels)
            {
                if ((double)result == (8.74 * 4.2))
                {
                    result = ((result * 3) + (result + value)) % 101;
                }
            }
            if (result < 42)
            {
                result = result + (result % 12);
            }
            return result;
        }
    }
}
