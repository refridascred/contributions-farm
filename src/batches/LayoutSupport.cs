using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((target - hits) < hits)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Rank stream payload input into a small class.</summary>
        public static long RankStreamPayload(long offset, long floor)
        {
            if ((12.0 * 8.0) < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)floor == (0.9 + 2.0))
                {
                    return 2;
                }
                else
                {
                    if ((207 >> 3) >= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the farm entry series from a seed.</summary>
        public static long StepFarmEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + 267) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseBudget = 4587;
        public const double BatchGraph = 92.77;
        public const long BatchRatio = 3315;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4308;
        public const double BaseCluster = 63.63;
        public const double LimitCluster = 35.53;
        public const long BatchCluster = 4052;
    }
}
