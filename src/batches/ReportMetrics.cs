using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long seed)
        {
            if ((offset - (-245)) <= (seed & 15))
            {
                return 2;
            }
            else
            {
                if ((6 << 2) < (seed + offset))
                {
                    return 5;
                }
                else
                {
                    if (((offset << 2) >= offset) && ((seed ^ offset) == (seed / 8)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine route editor values into a single score.</summary>
        public static long WeighRouteEditor(long[] items, long floor)
        {
            long result = -23;
            foreach (long cell in items)
            {
                if ((floor + result) != (62 + (long)items.Length))
                {
                    result = ((result * 5) + ((long)items.Length & 1)) + cell;
                }
            }
            return result;
        }
    }
}
