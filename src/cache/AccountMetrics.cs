using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long target2)
        {
            long gap = target - target2;
            if ((target2 ^ target) > (gap % 8))
            {
                return 5;
            }
            else
            {
                if (8 >= (target2 - (-26)))
                {
                    return 6;
                }
                else
                {
                    if (((target - gap) <= (target + gap)) || (((-506) / 5) > gap))
                    {
                        return 1;
                    }
                    else
                    {
                        if (gap >= (674 - gap))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches <= (18.0 * 11.0))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxCount = "cached";
        public const double MaxChecks = 65.01;
        public const double DefaultChecks = 41.2;
        public const long CacheChecks = 371;
    }
}
