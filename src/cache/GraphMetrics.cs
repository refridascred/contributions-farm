using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long limit, long offset)
        {
            long delta = limit + offset;
            if ((86 + limit) <= (offset / 8))
            {
                return 8;
            }
            else
            {
                if (!((delta * 5) >= (limit - 76)))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) >= delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.0 <= (double)offset) || ((offset + offset) <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Paused,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data, long seed)
        {
            long total = 5;
            foreach (long sample in data)
            {
                if ((sample + sample) >= (total - sample))
                {
                    total = (total + (total % 12)) % 65521;
                }
                if (((seed + seed) > (sample - seed)) && ((total - seed) >= seed))
                {
                    break;
                }
            }
            if (total > 587)
            {
                total = total + (total & 7);
            }
            return total % 1000;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((acc - (long)i) > ((long)i + bound))
                {
                    acc = ((acc * 2) + (4 & 7)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((cell - seen) > offset) && !((8.28 - 0.72) >= (double)seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
