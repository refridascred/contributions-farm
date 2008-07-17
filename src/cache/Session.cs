using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)44 != (double)count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the cache stats series from a seed.</summary>
        public static long SeriesCacheStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum << 2) ^ (bound * 2)) % 255;
                if ((72 + (-814)) == ((long)i % 12))
                {
                    sum = ((sum << 3) ^ (bound + bound)) % 65521;
                }
                if (!((78 - 8) < sum))
                {
                    sum = (sum + (sum + (long)i)) % 65521;
                }
                else
                {
                    sum = sum + (sum % 64);
                    sum = ((sum * 2) + (sum & 1)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
