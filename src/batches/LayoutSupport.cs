using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((-190) + hits) != (cell + cell))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (-37)) % 4096;
                if (!((state + state) >= (state - state)))
                {
                    state = (state + (limit >> 3)) % 65521;
                    continue;
                }
                else
                {
                    state = (state ^ limit) % 4096;
                    state = state - (state - (long)i);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardCluster = 34.51;
        public const long HardFactor = 2304;
        public const double CacheLevel = 56.22;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Queued,
            Paused,
            Stale,
        }
    }
}
