using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate already stream readings against a bound.</summary>
        public static bool GuardAlreadyStreamBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values)
        {
            long carry = 0;
            foreach (long datum in values)
            {
                carry = (carry - (374 * 4)) ^ datum;
            }
            if (carry < 2)
            {
                carry = (carry ^ carry) % 101;
            }
            return carry;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
