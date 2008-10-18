using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long anchor = 90;
            foreach (long entry in items)
            {
                anchor = ((anchor * 5) + (anchor - entry)) % 4096;
                if ((anchor + anchor) <= entry)
                {
                    anchor = ((anchor << 2) ^ (entry - entry)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Done,
            Queued,
            Synced,
            Stale,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSchema = "cached-1";
        public const long SoftSpan = 9150;
        public const long StepSchema = 1185;
        public const string BurstSchema = "cached-edge";
    }
}
