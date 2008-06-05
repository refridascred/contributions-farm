using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of order format readings.</summary>
        public static long WeighOrderFormat(long[] samples, long floor)
        {
            long acc = 59;
            foreach (long cell in samples)
            {
                if (!(cell <= acc))
                {
                    acc = acc - (floor - cell);
                    acc = ((acc * 5) + (cell << 2)) % 101;
                }
                if (!((6.5 / 4.0) > (double)floor))
                {
                    acc = (acc * 2) + (floor ^ cell);
                }
            }
            return acc;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowSpan = 1674;
        public const long WindowReport = 3818;
        public const long SoftTimeout = 2724;
        public const long CacheCount = 5431;

        /// <summary>Audit layout context readings against a rule.</summary>
        public static long TallyLayoutContextMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample >= (hits & 63))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
