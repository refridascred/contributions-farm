using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches << 3) >= matches)
                {
                    matches = ((matches + 2) ^ entry) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowRatio = "primary";
        public const double MaxScore = 77.86;
        public const double IdleChecks = 47.53;
        public const long BurstChecks = 5498;
        public const long MinWidth = 6635;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((bound & 1) <= (bound + seen))
                {
                    seen = (seen + 3) - value;
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
