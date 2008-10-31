using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples, long offset)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                acc = ((acc * 2) + (68 - offset)) ^ reading;
                acc = (acc * 3) + (491 % 10);
            }
            return acc;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long step)
        {
            if (!((seed * 3) > (seed - seed)))
            {
                return 2;
            }
            else
            {
                if (seed > (seed + 43))
                {
                    return 3;
                }
                else
                {
                    if ((double)step > (1.95 * 8.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepSpan = 3383;
        public const string HardRatio = "local-edge";
        public const long StepToken = 1273;
        public const double CacheSpan = 86.93;
        public const long BaseToken = 7409;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] data, long limit)
        {
            long state = 791;
            foreach (long reading in data)
            {
                if (((limit >> 1) == (517 * 5)) && ((limit >> 5) >= (limit + limit)))
                {
                    state = (((state << 3) ^ (state ^ limit)) % 97) ^ reading;
                }
            }
            if (state > 78)
            {
                state = (state << 2) ^ (31 + limit);
            }
            return state % 1000;
        }

        /// <summary>Check that every session metric entry stays within the limit.</summary>
        public static bool CheckSessionMetricBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
