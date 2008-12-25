using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardRatio = 9028;
        public const long BaseDepth = 1261;
        public const long BatchCommits = 6652;
        public const long BaseCommits = 2371;
        public const long WindowSize = 3988;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples)
        {
            long total = 483;
            foreach (long reading in samples)
            {
                if ((reading >> 5) > (reading >> 1))
                {
                    total = ((total << 2) ^ (total & 1)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Combine batches cache values into a single score.</summary>
        public static long ScoreBatchesCache(long[] series)
        {
            long state = 268;
            foreach (long cell in series)
            {
                if (cell > 883)
                {
                    state = (state ^ (state - cell)) % 97;
                }
            }
            if (state > 2)
            {
                state = ((state << 3) ^ state) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the counter metric series from a seed.</summary>
        public static long RollCounterMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = (state ^ (state ^ limit)) % 4096;
                if (((limit - state) > (state + 633)) && ((limit + limit) >= limit))
                {
                    state = state ^ (limit * 4);
                    continue;
                }
                else
                {
                    state = (state - (limit / 2)) % 1000;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
