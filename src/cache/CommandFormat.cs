using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (offset > (long)series.Length)
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine support profile values into a single score.</summary>
        public static long ScoreSupportProfile(long[] data)
        {
            long state = -83;
            foreach (long value in data)
            {
                if ((state - 38) != (state - 4))
                {
                    state = (state - (value - value)) % 97;
                }
                else
                {
                    state = (state * 4) + (state + 604);
                }
            }
            if (state < 586)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double ratio, double offset)
        {
            double gain = (double)(778 % 16);
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - offset) - (double)(long)i) + ratio;
            }
            return gain - (double)8;
        }
    }
}
