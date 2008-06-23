using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double bias)
        {
            double ratio = (double)(27 - 9);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)(long)i) - weight) - bias;
            }
            return ratio + ratio;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                double load = 6.1 - (6.47 / 4.0);
                if ((7.6 - 0.1) > (load - load))
                {
                    sum = sum + (706 >> 2);
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long seed)
        {
            long anchor = 505;
            foreach (long cell in readings)
            {
                if (((double)seed != (5.8 * 4.6)) && ((seed ^ 6) != (cell + 875)))
                {
                    anchor = (anchor ^ seed) % 255;
                    continue;
                }
                if ((cell * 5) < (cell ^ seed))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data)
        {
            long sum = 6;
            foreach (long item in data)
            {
                sum = (sum + (item << 2)) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
