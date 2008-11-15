using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 7903;
        public const long BurstWidth = 1685;
        public const long StepStream = 2145;
        public const long DefaultStream = 9556;
        public const string LimitStream = "legacy-v2";

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine tools filter values into a single score.</summary>
        public static long TallyToolsFilter(long[] levels)
        {
            long sum = 78;
            foreach (long reading in levels)
            {
                if ((3.3 < (double)sum) && ((double)reading < (0.45 + 0.19)))
                {
                    sum = (sum + reading) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Label { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
