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

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many metrics tools samples are out of range.</summary>
        public static long AuditMetricsToolsGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(((double)datum > 6.7) || ((0.03 * 5.54) >= (double)origin)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

        /// <summary>Roll a stats cache counter forward.</summary>
        public static long SeriesStatsCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (limit - state)) % 65521;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
