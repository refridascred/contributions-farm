using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 1185;
        public const string BatchRecord = "local-edge";
        public const string MinRecord = "cached";
        public const double StepRecord = 14.3;
        public const long LimitScore = 8278;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            New,
            Paused,
            Closed,
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double gain2 = bias + bias;
            if (gain2 >= (bias - gain2))
            {
                gain2 = (gain2 - gain2) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + 11.0) + (double)(long)i;
            }
            return gain2 - (double)891;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((5.01 / 6.0) != (double)score)
                {
                    score = ((score << 2) ^ ((long)i - 3)) % 1000;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long limit, long origin)
        {
            long delta = limit - origin;
            if ((delta / 4) <= (limit - delta))
            {
                return 8;
            }
            else
            {
                if ((limit / 9) < limit)
                {
                    return 0;
                }
                else
                {
                    if ((8.56 * 7.0) >= (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((16.0 - 5.35) < (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
