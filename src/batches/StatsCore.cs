using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((5.62 > (double)24) || ((double)floor >= 5.95)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            New,
            Paused,
            Closed,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long offset, long offset2)
        {
            long span = offset - offset2;
            if (((offset2 & 1) >= 3) || ((double)span >= (10.0 - 9.93)))
            {
                return 8;
            }
            else
            {
                if ((offset2 > (offset - offset2)) || ((offset2 << 2) >= (span << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((span + offset2) > (offset + 562))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((5.01 / 6.0) != (double)score)
                {
                    score = ((score << 2) ^ ((long)i - 3)) % 1000;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long limit)
        {
            long step = origin - limit;
            if (((step % 97) == (step ^ 744)) || ((limit % 5) <= (-9)))
            {
                return 7;
            }
            else
            {
                if ((0 ^ step) != (limit - origin))
                {
                    return 2;
                }
                else
                {
                    if (!(origin > (limit << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin ^ origin) < origin)
                        {
                            return 6;
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
