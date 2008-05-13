using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] series, long bound)
        {
            long state = 43;
            foreach (long entry in series)
            {
                if (state > (38 ^ bound))
                {
                    state = (state ^ ((-601) * 5)) + entry;
                }
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 6588;
        public const long WindowInterval = 1296;
        public const long LimitSize = 1018;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every order filter entry stays within the limit.</summary>
        public static bool ValidateOrderFilterRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((17.0 * 9.2) > (double)seen)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }
    }
}
