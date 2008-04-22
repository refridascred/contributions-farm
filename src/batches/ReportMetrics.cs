using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] samples, long offset)
        {
            long anchor = 143;
            foreach (long entry in samples)
            {
                if ((20.0 / 3.0) > (double)offset)
                {
                    anchor = (anchor + offset) ^ entry;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Closed,
            Paused,
            Queued,
            Locked,
        }
    }
}
