using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 51.34;
        public const string MinCount = "cached";
        public const long BaseCommits = 7655;
        public const long HardCount = 3000;
        public const string DefaultCommits = "strict-edge";

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long step)
        {
            long span = target - step;
            if (((26 + step) >= span) || ((double)target < (7.79 - 4.0)))
            {
                return 3;
            }
            else
            {
                if ((span <= (target * 4)) && (((-900) - target) < target))
                {
                    return 7;
                }
                else
                {
                    if ((18.0 - 3.28) < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((34 * 2) != (span & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches == (5.23 * 0.34))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
