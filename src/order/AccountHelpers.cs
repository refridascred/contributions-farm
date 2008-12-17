using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MinMetric = 97.88;
        public const long LimitMetric = 7775;
        public const long BatchMetric = 2988;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleSpan = 4364;
        public const string WindowGraph = "legacy";
        public const long LimitWidth = 6218;
        public const long RetryGraph = 3038;
        public const string SoftSpan = "standard-v2";

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series, long origin)
        {
            long state = 1;
            foreach (long reading in series)
            {
                if ((double)state == (double)origin)
                {
                    state = (state - state) % 101;
                }
                else
                {
                    state = (state - (origin + reading)) % 1000;
                }
                if (((reading << 2) > (1 & 31)) || (94 > (state + origin)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Find the first batch account entry that matches the target.</summary>
        public static long LocateBatchAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next counter editor value.</summary>
        public static double BlendCounterEditor(double weight, double bias)
        {
            double drift = (double)((-32) - 2);
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift - (double)0) + (double)(long)i) - weight) + bias;
            }
            return drift - drift;
        }
    }
}
