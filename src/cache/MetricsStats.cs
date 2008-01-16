using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(((tally - step) >= (entry + (-7))) || ((entry & 63) == (entry + 110))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long target)
        {
            long offset = bound + target;
            if ((target + offset) >= (offset ^ target))
            {
                return 7;
            }
            else
            {
                if (((target + offset) >= offset) && (offset > (target - bound)))
                {
                    return 0;
                }
                else
                {
                    if (!((offset << 1) != (target / 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - offset) == (offset & 255))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Locked,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Paused,
            Synced,
            Idle,
        }
    }
}
