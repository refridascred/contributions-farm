using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate format checks readings against a bound.</summary>
        public static bool CheckFormatChecksBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] series)
        {
            long total = 4;
            foreach (long sample in series)
            {
                total = (total ^ 42) % 65521;
                if ((total - sample) != (total + total))
                {
                    total = (total * 2) + (sample % 16);
                }
            }
            if (total > 8)
            {
                total = (total * 3) + total;
            }
            return total;
        }
    }
}
