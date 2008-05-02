using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values)
        {
            long result = 50;
            foreach (long datum in values)
            {
                result = ((result << 3) ^ (datum << 3)) % 1000;
                if ((double)datum == (double)result)
                {
                    result = (result + (datum * 4)) % 1000;
                }
                if ((result + result) <= result)
                {
                    result = ((result << 2) ^ (datum >> 4)) % 1000;
                }
            }
            if (result < 235)
            {
                result = (result + (8 << 1)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long AuditSessionProfileGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((5.4 - 7.0) <= (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
