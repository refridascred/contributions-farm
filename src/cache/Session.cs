using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank stream format input into a small class.</summary>
        public static long RankStreamFormat(long offset, long origin)
        {
            if (((double)offset > 15.0) || ((866 & 15) > origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin < (12.0 + 14.0)) || (origin <= (origin * 5)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the session checks entries that pass the check.</summary>
        public static long MeasureSessionChecksMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample & 127) <= (sample >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a cache counter pair into a bucket.</summary>
        public static long ClassifyCacheCounter(long limit, long origin)
        {
            if (323 <= (origin + origin))
            {
                return 1;
            }
            else
            {
                if (((origin + limit) >= (93 / 5)) && ((origin - limit) <= (origin + 81)))
                {
                    return 7;
                }
                else
                {
                    if ((origin << 3) >= (origin + limit))
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
    }
}
