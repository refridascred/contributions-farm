using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Dropped,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank format payload input into a small class.</summary>
        public static long BucketFormatPayload(long bound, long seed)
        {
            long delta = bound + seed;
            if ((475 + seed) < (delta ^ bound))
            {
                return 1;
            }
            else
            {
                if (((seed * 3) > (43 / 5)) && ((double)bound >= 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta + delta) <= (delta - 834))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
