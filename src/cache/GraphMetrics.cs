using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Active,
            Stale,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 678;
        public const double MinRoute = 82.54;
        public const long DefaultRoute = 9350;
        public const double IdleSize = 45.34;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) < sample)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
