using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] items)
        {
            long total = -143;
            foreach (long item in items)
            {
                if ((792 << 3) > (54 - item))
                {
                    total = (total + ((long)items.Length << 3)) % 97;
                }
            }
            if (total > 843)
            {
                total = (total * 2) + (total + 633);
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 18.35;
        public const long RetrySize = 9100;
        public const long CacheSchema = 7209;

        /// <summary>Check that every metric layout entry stays within the limit.</summary>
        public static bool VerifyMetricLayoutRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
