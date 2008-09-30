using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double scale, double bias)
        {
            double load = scale - (scale - scale);
            for (int i = 0; i < 7; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - (double)6;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepCount = 92.66;
        public const long StepSession = 1581;
        public const long WindowSession = 7382;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen < (seen ^ (long)readings.Length))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultFactor = "staging-edge";
        public const string IdleMetric = "stable-v2";
        public const double DefaultMetric = 82.96;
        public const long LimitMetric = 3343;
        public const long LimitFactor = 2159;

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] samples, long seed)
        {
            long state = 35;
            foreach (long cell in samples)
            {
                if (cell <= (695 ^ 11))
                {
                    state = ((state * 2) + seed) % 65521;
                }
            }
            if (state < 892)
            {
                state = (state << 2) ^ (seed - state);
            }
            return state;
        }
    }
}
