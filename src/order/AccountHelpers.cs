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

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) != 0))
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
