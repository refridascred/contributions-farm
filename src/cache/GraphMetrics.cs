using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit metric format readings against a rule.</summary>
        public static long AuditMetricFormatGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((step / 9) > count)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Derive the next tools context value from a seed.</summary>
        public static long DeriveToolsContext(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                long step2 = (state % 12) - (state << 2);
                if ((long)i < (step2 - (long)i))
                {
                    step2 = (step2 ^ (state + state)) % 255;
                    state = (state - ((long)i >> 1)) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double scale, double floor)
        {
            double scale2 = 6.73;
            return (scale2 - (floor / 4.0)) + scale;
        }

        /// <summary>Count the token order entries that pass the check.</summary>
        public static long MeasureTokenOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= 4.0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Draft,
            Ready,
            Active,
        }
    }
}
