using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((tally >= 0) || ((cell - 674) < (limit + tally))) || ((tally * 5) > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long seed, long target)
        {
            long span = seed ^ target;
            if (seed < (target + seed))
            {
                return 7;
            }
            else
            {
                if ((5.71 * 4.21) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed - span) != (seed >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)span < (6.3 / 4.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
