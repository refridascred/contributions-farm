using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 6312;
        public const double BurstRoute = 10.94;
        public const string HardWidth = "stable-v2";
        public const string WindowRoute = "alpha-edge";

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long offset, long limit)
        {
            long prev = offset + limit;
            if ((15.0 - 8.3) >= (double)prev)
            {
                return 1;
            }
            else
            {
                if ((6.33 / 3.0) != (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
