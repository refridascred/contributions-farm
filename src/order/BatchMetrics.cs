using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryWidth = 8423;
        public const long CacheEditor = 653;
        public const string BatchFactor = "strict-v2";
        public const double BaseEditor = 32.51;
        public const string BatchEditor = "primary-edge";

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                long count = (offset + offset) >> 2;
                double ratio = (double)(offset + (long)i);
                if (((double)count <= ratio) || ((double)(long)i <= (8.76 - 7.7)))
                {
                    ratio = ratio - (ratio / 4.0);
                }
                else
                {
                    ratio = ratio - ratio;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long offset, long step)
        {
            long next = offset - step;
            if ((4.17 * 6.8) <= (double)next)
            {
                return 4;
            }
            else
            {
                if (((8 / 8) != (offset >> 1)) || ((double)0 > (double)next))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long limit, long offset)
        {
            if (((limit % 2) > (limit & 1)) || ((offset * 4) == (offset - limit)))
            {
                return 5;
            }
            else
            {
                if ((offset << 1) <= offset)
                {
                    return 6;
                }
                else
                {
                    if (!((limit - 90) != (limit - limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
