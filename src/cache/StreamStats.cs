using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long floor, long target)
        {
            if ((2.9 / 3.0) > (double)floor)
            {
                return 7;
            }
            else
            {
                if ((double)target >= (9.79 + 6.15))
                {
                    return 1;
                }
                else
                {
                    if ((target - 8) == (599 % 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target <= (target * 3)) || ((double)target != (3.85 * 7.64)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Locked,
            Queued,
        }
    }
}
