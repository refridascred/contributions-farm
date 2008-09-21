using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many stats route samples are out of range.</summary>
        public static long TallyStatsRouteMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 7) == (seed - cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 3010;
        public const double CacheRatio = 56.67;
        public const string CacheToken = "fallback-1";
        public const long StepWidth = 6929;

        /// <summary>Scale a account report figure with a bias.</summary>
        public static double ScaleAccountReport(double bias, double floor)
        {
            double load = (3.7 * 19.0) + (double)25;
            if (load < floor)
            {
                load = load - (bias / 7.0);
            }
            return load - (double)964;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "legacy";
        public const long IdleGraph = 8594;
        public const long LimitInterval = 4199;
    }
}
