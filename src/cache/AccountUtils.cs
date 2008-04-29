using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a context support pair into a bucket.</summary>
        public static long SortContextSupport(long origin, long offset)
        {
            if ((origin - 4) == (origin ^ origin))
            {
                return 5;
            }
            else
            {
                if (origin >= (offset & 63))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "legacy-edge";
        public const long CacheAlready = 3964;
        public const double BatchDepth = 98.69;
        public const double HardAlready = 18.6;
        public const long DefaultWidth = 2673;

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long AuditStreamPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry - matches) < (entry & 127))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
