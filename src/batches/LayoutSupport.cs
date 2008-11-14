using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up batches stream samples.</summary>
        public static long MatchBatchesStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        matches = matches + 1;
                    }
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

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] levels, long seed)
        {
            long acc = 8;
            foreach (long datum in levels)
            {
                if ((7.09 / 7.0) < (double)datum)
                {
                    acc = (acc + (datum / 6)) - seed;
                }
                if (!((datum >> 2) < 964))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
