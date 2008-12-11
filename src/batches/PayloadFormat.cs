using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstLevel = 9078;
        public const string IdleInterval = "primary-1";
        public const double IdleWidth = 12.7;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + seed) >= (reading / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen >= (0 % 8))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
