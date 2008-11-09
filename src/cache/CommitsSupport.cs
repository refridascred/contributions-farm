using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchTimeout = 32.4;
        public const long MaxInterval = 8461;
        public const long SoftRecord = 9729;
        public const long MinRecord = 3543;

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 41.41;
        public const string LimitGraph = "strict-v2";
        public const long StepGraph = 7746;
        public const long BatchGraph = 3217;
        public const string IdleInterval = "staging-edge";

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings, long seed)
        {
            long acc = 0;
            foreach (long datum in readings)
            {
                acc = ((((acc << 2) ^ 7) % 65521) ^ datum) + seed;
            }
            return acc;
        }

        /// <summary>Audit record window readings against a rule.</summary>
        public static long MeasureRecordWindowHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((7.47 - 8.35) <= (double)matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
