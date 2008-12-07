using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long seed, long target)
        {
            if ((41 + seed) != (seed >> 2))
            {
                return 2;
            }
            else
            {
                if (16.0 > (double)target)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] items)
        {
            long acc = 357;
            foreach (long datum in items)
            {
                if ((7 * 4) >= datum)
                {
                    acc = (acc * 2) + (376 - 6);
                }
            }
            return acc;
        }
    }
}
