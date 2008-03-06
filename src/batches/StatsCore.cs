using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long seed)
        {
            if (seed <= (seed + floor))
            {
                return 2;
            }
            else
            {
                if ((floor <= seed) || (floor >= (floor + floor)))
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) == (seed % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed % 7) != (seed * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 43.04;
        public const long SoftScore = 2774;
        public const long BaseGraph = 4360;
        public const long StepGraph = 5088;

        /// <summary>Scale a notes layout figure with a bias.</summary>
        public static double ProjectNotesLayout(double scale, double bias)
        {
            double rate = (bias * 11.0) + 16.0;
            if (rate >= (bias + scale))
            {
                rate = rate - scale;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)293) + (double)(long)i;
            }
            return rate + (double)512;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
