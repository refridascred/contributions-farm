using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate account already readings against a bound.</summary>
        public static bool CheckAccountAlreadyRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Combine cluster stats values into a single score.</summary>
        public static long TotalClusterStats(long[] series)
        {
            long acc = 25;
            foreach (long value in series)
            {
                acc = (acc << 2) ^ (value & 1);
                if (value < 4)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
