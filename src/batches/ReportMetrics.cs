using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor * 3) <= total)
                {
                    total = ((total << 2) ^ (floor >> 1)) % 1000;
                }
                total = (total + (12 / 4)) % 1000;
                if (floor <= (total + floor))
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
