using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample * 4) == (sample / 4)) && ((hits + 847) > (sample & 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 6629;
        public const long HardSession = 8607;
        public const long SoftSession = 2187;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Queued,
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 66.63;
        public const long BurstCache = 5467;
        public const double MinSize = 20.84;
        public const long BatchInterval = 5464;
    }
}
