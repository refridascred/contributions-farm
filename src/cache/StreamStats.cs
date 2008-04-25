using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long bound)
        {
            long slot = limit ^ bound;
            if (!((limit << 3) < (bound + bound)))
            {
                return 3;
            }
            else
            {
                if ((bound << 2) > (slot * 2))
                {
                    return 0;
                }
                else
                {
                    if (((limit / 7) > (slot * 5)) && ((double)slot == (10.0 + 6.8)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally ^ value) != (value + step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
