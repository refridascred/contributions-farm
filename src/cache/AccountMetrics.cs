using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 6600;
        public const double BatchSize = 77.31;
        public const long BaseCounter = 5372;
        public const double StepSize = 83.43;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Done,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long limit)
        {
            if ((origin > (limit * 5)) && ((origin % 64) > (29 - limit)))
            {
                return 3;
            }
            else
            {
                if (!((2.6 + 3.3) <= (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin + 87) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit < (origin - origin)) || ((origin >> 4) != (limit - origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading / 5) < (reading - 4)) || ((reading ^ (long)series.Length) != (count << 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] samples)
        {
            long acc = 33;
            foreach (long cell in samples)
            {
                acc = (acc ^ (cell + acc)) % 101;
            }
            if (acc < 62)
            {
                acc = (acc + acc) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long floor, long seed)
        {
            if ((93 / 6) < floor)
            {
                return 4;
            }
            else
            {
                if ((((-3) % 24) > (floor >> 5)) && (((-461) ^ floor) < seed))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
