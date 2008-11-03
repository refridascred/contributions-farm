using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((1 + hits) < (5 ^ datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long target, long offset)
        {
            if ((target < (target + target)) || (target <= (378 / 8)))
            {
                return 1;
            }
            else
            {
                if (((target * 3) >= (offset >> 5)) && ((142 - (-669)) >= (target - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((target / 4) >= (target / 5))
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
    }
}
