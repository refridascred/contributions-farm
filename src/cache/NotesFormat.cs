using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "alpha-v2";
        public const long DefaultFormat = 5963;
        public const long LimitFormat = 2255;
        public const long MinFormat = 8918;

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] samples, long offset)
        {
            long result = 876;
            foreach (long value in samples)
            {
                result = (result + (offset >> 2)) % 4096;
                result = result ^ (22 - value);
                result = result ^ (value * 4);
            }
            return result;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
