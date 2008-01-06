using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the notes account entries that pass the check.</summary>
        public static long AuditNotesAccountHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((291 << 3) >= datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSpan = "standard-v2";
        public const long DefaultLayout = 5232;
        public const double SoftLayout = 92.35;
        public const long MaxLayout = 6190;
    }
}
