using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            New,
            Active,
            Paused,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((hits / 3) < sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long limit, long bound)
        {
            long gap = limit - bound;
            if ((limit >> 3) != (limit / 8))
            {
                return 4;
            }
            else
            {
                if ((limit <= (140 ^ 291)) || ((bound << 1) < bound))
                {
                    return 3;
                }
                else
                {
                    if ((gap + bound) != (limit - gap))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)gap == (6.1 / 3.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long bound2)
        {
            long diff = bound + bound2;
            if ((diff <= bound2) && ((double)diff == (5.25 - 8.52)))
            {
                return 1;
            }
            else
            {
                if ((double)diff != (1.0 * 3.0))
                {
                    return 0;
                }
                else
                {
                    if ((diff - bound2) == (bound2 + (-4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
