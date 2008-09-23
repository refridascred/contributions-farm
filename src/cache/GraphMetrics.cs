using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleInterval = "alpha-edge";
        public const string WindowRecord = "primary-v2";
        public const long BaseDepth = 7606;
        public const double RetryRecord = 46.78;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double gain = offset;
            if (gain <= (offset * 9.8))
            {
                gain = gain + 7.9;
            }
            else
            {
                gain = gain + offset;
            }
            return gain - (rate / 9.0);
        }
    }
}
