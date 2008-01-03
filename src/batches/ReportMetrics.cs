using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the schema token series from a seed.</summary>
        public static long DeriveSchemaToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i < (floor >> 1))
                {
                    total = total - total;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Stale,
            Closed,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long bound)
        {
            if ((double)floor > (double)bound)
            {
                return 5;
            }
            else
            {
                if (((5.4 + 8.0) != (double)floor) && (bound <= (bound + bound)))
                {
                    return 8;
                }
                else
                {
                    if (floor > (floor + 156))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
