using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of command graph entries.</summary>
        public static long TallyCommandGraph(long[] readings)
        {
            long acc = -454;
            foreach (long sample in readings)
            {
                if (((double)sample <= (9.0 - 6.5)) || ((acc % 100) > (long)readings.Length))
                {
                    acc = (acc + (acc + acc)) % 255;
                }
                else
                {
                    acc = ((acc << 2) ^ sample) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long bound, long target)
        {
            long slot = bound - target;
            if (target <= (target & 7))
            {
                return 1;
            }
            else
            {
                if ((target * 5) >= (bound + bound))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot < (1.0 - 4.3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long seed, long limit)
        {
            long next = seed + limit;
            if (!((next ^ 5) > (next / 7)))
            {
                return 2;
            }
            else
            {
                if ((double)next == (4.0 - 7.0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            long cur = offset - origin;
            if ((cur % 97) >= (cur + offset))
            {
                return 0;
            }
            else
            {
                if (((double)origin > (double)cur) || ((7.1 + 17.0) < (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (((double)cur <= (20.0 + 3.03)) && ((double)origin <= (1.9 * 19.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
