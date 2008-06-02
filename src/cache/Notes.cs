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

        /// <summary>Check that every account batch entry stays within the limit.</summary>
        public static bool ValidateAccountBatchBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 7097;
        public const long CacheRatio = 5858;
        public const double CacheNotes = 97.71;
        public const double IdleDepth = 75.8;
    }
}
