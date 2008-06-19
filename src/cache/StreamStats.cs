using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                if (((924 - (long)i) >= (long)i) || ((acc << 1) >= step))
                {
                    acc = acc ^ (acc ^ (long)i);
                    continue;
                }
                acc = (acc * 5) + acc;
                acc = acc - (long)i;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark << 3) ^ limit) % 65521;
                mark = mark + (mark + mark);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long offset)
        {
            if ((floor + 5) <= offset)
            {
                return 5;
            }
            else
            {
                if (((floor >> 2) != (offset ^ 0)) || ((floor % 8) != (offset / 9)))
                {
                    return 4;
                }
                else
                {
                    if (((1.46 / 2.0) >= (double)offset) || ((9 >> 4) <= (offset & 127)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor << 3) < 6) || ((10.0 - 7.0) == (double)floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
