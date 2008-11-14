using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long target)
        {
            if ((double)target == (0.92 * 8.59))
            {
                return 4;
            }
            else
            {
                if ((302 % 2) >= (seed + target))
                {
                    return 8;
                }
                else
                {
                    if ((seed >> 1) < (22 ^ 0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target >= (target + target))
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

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many tools route samples are out of range.</summary>
        public static long AuditToolsRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (1.24 - 1.8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)datum > (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
