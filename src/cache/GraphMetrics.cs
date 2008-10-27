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

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long target)
        {
            long acc = 44;
            foreach (long item in samples)
            {
                if ((item - acc) < (62 & 63))
                {
                    acc = ((acc - (item % 64)) % 97) - target;
                }
            }
            return acc;
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
