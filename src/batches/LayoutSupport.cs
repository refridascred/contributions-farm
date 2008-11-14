using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((reading ^ matches) >= (reading * 3)) || ((matches << 2) > (matches << 1))) && ((7 - reading) < 54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long step)
        {
            if (((double)origin <= (double)step) || (origin < step))
            {
                return 7;
            }
            else
            {
                if ((4.0 / 6.0) >= (6.93 - 2.1))
                {
                    return 8;
                }
                else
                {
                    if ((origin % 2) == (268 % 3))
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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long target, long offset)
        {
            if (offset >= (offset + target))
            {
                return 1;
            }
            else
            {
                if ((175 >= (target / 7)) || ((target + offset) != (target & 127)))
                {
                    return 0;
                }
                else
                {
                    if (target >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((323 / 7) <= (target % 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Roll a counter stats counter forward.</summary>
        public static long StepCounterStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((total & 31) > (total + (long)i)))
                {
                    total = ((total * 4) + (limit + limit)) % 65521;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
