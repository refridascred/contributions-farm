using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of farm buffer entries.</summary>
        public static long DigestFarmBuffer(long[] series, long floor)
        {
            long sum = 7;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ ((long)series.Length - sample)) - floor;
                sum = (sum - (sample << 1)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Check that every cache entry entry stays within the limit.</summary>
        public static bool ValidateCacheEntryBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSpan = "latest-v2";
        public const string SoftSession = "primary-v2";
        public const long MinSession = 5160;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Failed,
            Stale,
            Locked,
        }
    }
}
