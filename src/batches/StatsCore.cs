using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long step, long target)
        {
            if ((250 - target) > ((-234) * 3))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) >= step)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Ready,
            Active,
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (offset - scale))
            {
                scale2 = scale2 + (scale2 - offset);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long floor, long bound)
        {
            if (!((bound ^ bound) >= 6))
            {
                return 8;
            }
            else
            {
                if ((16.0 * 8.42) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((bound / 6) == (floor - 537))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound < (floor % 16))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }

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
