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

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Ready,
            Idle,
            Closed,
            Active,
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

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i >> 3) > (701 + anchor))
                {
                    anchor = (anchor ^ bound) % 65521;
                    anchor = anchor ^ (921 & 1);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
