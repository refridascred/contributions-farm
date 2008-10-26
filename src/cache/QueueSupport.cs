using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long offset)
        {
            if ((bound << 2) >= (offset >> 1))
            {
                return 0;
            }
            else
            {
                if (7.5 < (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Synced,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
