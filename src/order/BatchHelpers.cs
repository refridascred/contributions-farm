using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics already figure with a bias.</summary>
        public static double ProjectMetricsAlready(double rate, double offset)
        {
            double load = (offset * 4.1) * 8.0;
            if (load > (double)234)
            {
                load = (load + (load * 15.0)) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load - (double)9;
        }
    }
}
