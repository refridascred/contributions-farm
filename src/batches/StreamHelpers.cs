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

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 11.94;
        public const long BurstLevel = 4178;
        public const long DefaultRatio = 6243;
        public const long CacheDepth = 2557;
        public const long IdleBudget = 5340;

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long bound, long step)
        {
            long span = bound - step;
            if (((double)step != (9.0 - 3.0)) && (bound >= (bound - span)))
            {
                return 0;
            }
            else
            {
                if ((double)span > (4.0 / 7.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
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
