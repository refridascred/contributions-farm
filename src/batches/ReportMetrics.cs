using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of token order readings.</summary>
        public static long CompareTokenOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (total - (long)i)) % 97;
                if (((double)origin < 6.2) && ((total * 4) < total))
                {
                    total = total - (997 - origin);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
