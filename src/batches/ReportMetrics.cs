using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank entry session input into a small class.</summary>
        public static long ClassifyEntrySession(long step, long floor)
        {
            long cur = step - floor;
            if (step > (55 + cur))
            {
                return 1;
            }
            else
            {
                if ((5.0 < (double)floor) && (0.99 >= (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((1.0 - 7.0) > (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor < cur)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
