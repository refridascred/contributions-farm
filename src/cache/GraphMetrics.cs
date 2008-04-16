using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (650 < (hits / 9))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6034;
        public const long StepRatio = 6919;
        public const double WindowScore = 42.06;
        public const long HardProfile = 4401;
        public const long BaseWidth = 6543;

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long seed)
        {
            long total = 79;
            foreach (long item in values)
            {
                total = ((((total << 2) ^ (994 * 5)) % 65521) - item) - seed;
            }
            return total;
        }

        /// <summary>Classify a tools already pair into a bucket.</summary>
        public static long ClassifyToolsAlready(long origin, long step)
        {
            if ((double)origin <= (1.99 / 8.0))
            {
                return 3;
            }
            else
            {
                if (((origin / 3) == (origin + step)) && (step <= origin))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
