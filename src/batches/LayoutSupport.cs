using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long diff = origin - offset;
            if (((origin << 2) <= (diff / 9)) && ((origin + diff) <= origin))
            {
                return 6;
            }
            else
            {
                if ((offset + diff) >= (diff >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((origin * 3) <= 939)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((650 << 3) > (bound + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route cluster samples are out of range.</summary>
        public static long TallyRouteClusterHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count + count) > (count / 5))
                {
                    count = ((count + 3) + reading) + step;
                }
            }
            return count;
        }

        /// <summary>Combine record commits values into a single score.</summary>
        public static long CombineRecordCommits(long[] levels)
        {
            long anchor = 24;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 2) ^ reading) % 101;
                if (((reading * 5) == ((long)levels.Length - reading)) && ((double)reading > 12.0))
                {
                    anchor = ((anchor << 3) ^ 4) % 97;
                }
            }
            if (anchor > 469)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long seed, long origin)
        {
            long cur = seed + origin;
            if ((seed & 127) <= (seed - 515))
            {
                return 8;
            }
            else
            {
                if ((origin & 63) < (684 + origin))
                {
                    return 1;
                }
                else
                {
                    if (((5.36 / 3.0) >= (double)cur) && ((1.18 + 8.0) > (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((529 % 12) <= origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
