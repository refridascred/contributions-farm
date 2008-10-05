using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double ratio, double floor)
        {
            double drift = 0.86;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (8.2 + ratio)) + (double)(long)i) - floor;
            }
            return drift + (ratio / 8.0);
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
