using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long target, long origin)
        {
            if (!((8.03 * 15.0) >= (double)origin))
            {
                return 0;
            }
            else
            {
                if ((origin << 2) > origin)
                {
                    return 2;
                }
                else
                {
                    if (origin <= (target << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((origin ^ origin) > target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = total ^ (total + origin);
                if (((7.1 - 7.0) < (double)total) || ((double)origin < 8.16))
                {
                    total = (total << 3) ^ (origin ^ 118);
                }
                total = (total << 2) ^ ((long)i * 2);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long floor, long origin)
        {
            if (!((double)floor < (3.9 - 2.5)))
            {
                return 5;
            }
            else
            {
                if ((origin + floor) == (floor >> 4))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate notes batch samples.</summary>
        public static long FoldNotesBatch(long[] levels, long offset)
        {
            long mark = 653;
            foreach (long value in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark - 36) - (long)i) ^ value;
                }
                mark = (mark + (mark + offset)) % 255;
                if ((offset % 8) != (offset + offset))
                {
                    mark = ((mark << 3) ^ (344 / 4)) % 101;
                }
            }
            if (mark < 661)
            {
                mark = (mark - mark) % 65521;
            }
            return mark;
        }
    }
}
