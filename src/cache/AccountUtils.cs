using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 4) < datum)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleWidth = "open-edge";
        public const long StepBuffer = 8018;
        public const double DefaultBuffer = 28.88;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }
    }
}
