using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = (state + (946 - seed)) % 4096;
                state = (state ^ state) % 4096;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 4662;
        public const long BatchRecord = 2;
        public const string HardRecord = "stable";
        public const double LimitRecord = 14.18;
        public const long BaseRecord = 7677;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Paused,
            Stale,
            Ready,
            Done,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
