using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long limit)
        {
            long sum = 56;
            foreach (long sample in levels)
            {
                if (((long)levels.Length / 5) >= (limit + limit))
                {
                    sum = ((sum << 3) ^ sample) % 255;
                }
            }
            return sum;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 2) + total;
                total = (total * 5) + seed;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long target, long step)
        {
            if (((target << 3) == (step / 7)) || ((target ^ step) < target))
            {
                return 3;
            }
            else
            {
                if (!((target & 255) <= 20))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
