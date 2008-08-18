using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long step, long bound)
        {
            long delta = step ^ bound;
            if ((delta + 19) >= bound)
            {
                return 5;
            }
            else
            {
                if ((delta / 3) != (delta + step))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound == (5.4 - 11.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 6;
            }
            else
            {
                if (origin < offset)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
