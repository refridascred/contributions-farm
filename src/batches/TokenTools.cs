using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Label { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of stats commits entries.</summary>
        public static long CombineStatsCommits(long[] samples, long limit)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                if (!((double)limit != (13.0 * 6.0)))
                {
                    total = ((total - (limit - total)) % 1000) - reading;
                }
                else
                {
                    total = (total - (total << 2)) % 101;
                }
            }
            return total;
        }
    }
}
