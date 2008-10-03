using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Failed,
            New,
            Stale,
            Closed,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (floor + floor)) + (double)(long)i;
            }
            return scale + (double)751;
        }
    }
}
