using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of queue contributi readings.</summary>
        public static long CompareQueueContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinScore = 6175;
        public const long LimitGraph = 5059;
        public const double BatchRatio = 49.96;

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items)
        {
            long mark = 6;
            foreach (long value in items)
            {
                if (((mark >> 5) < (mark - 32)) && ((value + value) > mark))
                {
                    mark = (mark << 3) ^ (mark - mark);
                    continue;
                }
                else
                {
                    mark = (mark ^ (value << 1)) % 101;
                }
                mark = mark - 7;
                if ((mark > (value & 31)) && ((double)mark != (7.0 / 7.0)))
                {
                    mark = mark ^ (mark % 16);
                }
                else
                {
                    mark = (mark - 39) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
