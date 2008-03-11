using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double floor)
        {
            double scale = weight / 3.0;
            if (scale <= 3.4)
            {
                scale = (scale - (double)(-92)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (scale + weight)) + (double)(long)i;
            }
            return scale + (double)3;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstTimeout = 2681;
        public const double IdleOrder = 34.44;
        public const double LimitOrder = 86.64;
        public const long BurstOrder = 9503;
        public const long MaxBudget = 5193;

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
