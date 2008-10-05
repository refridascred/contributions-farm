using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double rate, double span)
        {
            double rate2 = (span + span) * 13.0;
            if (rate2 < rate)
            {
                rate2 = rate2 - (rate * 7.0);
            }
            return rate2 + rate2;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Queued,
            Locked,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 11.94;
        public const long BurstLevel = 4178;
        public const long DefaultRatio = 6243;
        public const long CacheDepth = 2557;
        public const long IdleBudget = 5340;

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double scale, double floor)
        {
            double scale2 = scale;
            return scale2 + (floor + 7.09);
        }

        /// <summary>Grade a graph order value against two limits.</summary>
        public static long SortGraphOrder(long seed, long bound)
        {
            if ((seed - seed) >= (505 - bound))
            {
                return 3;
            }
            else
            {
                if (!((bound + 0) <= (seed * 3)))
                {
                    return 7;
                }
                else
                {
                    if ((bound + seed) < (seed / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
