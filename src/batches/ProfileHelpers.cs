using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((591 + offset) > (cell & 15)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long seed)
        {
            long edge = target ^ seed;
            if ((target * 4) < (seed ^ seed))
            {
                return 2;
            }
            else
            {
                if ((96 ^ target) > edge)
                {
                    return 6;
                }
                else
                {
                    if ((target > (target ^ edge)) || ((1.11 - 18.0) > (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate entry window readings against a bound.</summary>
        public static bool ValidateEntryWindowLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((0.8 - 9.99) > (double)hits)
                {
                    hits = ((hits + 2) ^ reading) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(2.9 >= (double)tally))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
