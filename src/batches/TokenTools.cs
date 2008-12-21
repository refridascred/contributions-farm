using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long floor, long bound)
        {
            long edge = floor + bound;
            if ((886 + edge) < edge)
            {
                return 6;
            }
            else
            {
                if (!(367 < (floor ^ 788)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound / 5) >= (932 + edge)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound >> 1) <= bound) && ((floor - edge) == (bound / 8)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value * 4) > (value % 8))
                {
                    seen = (seen + 2) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
