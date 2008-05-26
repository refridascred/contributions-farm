using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double rate, double bias)
        {
            double scale = (double)((-9) - 90);
            return (scale + rate) + bias;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Paused,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Count tools order pairs that satisfy a relation.</summary>
        public static long CompareToolsOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every counter cluster entry stays within the limit.</summary>
        public static bool GuardCounterClusterLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
