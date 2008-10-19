using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report contributi samples are out of range.</summary>
        public static long TallyReportContributiOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count * 5) == (cell * 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
