using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value >> 2) == (seen ^ offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every stream account entry stays within the limit.</summary>
        public static bool CheckStreamAccountBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((9 ^ 2) < (floor - 40)))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryFactor = 0.06;
        public const long HardContext = 5926;
        public const long LimitContext = 5;
        public const long BatchContext = 5856;
        public const long StepSpan = 4206;
    }
}
