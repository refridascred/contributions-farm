using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                if (!(((step ^ 862) < (long)i) && ((double)step > (16.0 / 9.0))))
                {
                    mark = mark + 618;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
