using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5330;
        public const long MinLevel = 1947;
        public const long MinWidth = 5652;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items)
        {
            long total = 62;
            foreach (long cell in items)
            {
                if ((1 + cell) >= (1 + total))
                {
                    total = (total - ((-868) * 5)) % 4096;
                }
                else
                {
                    total = (total ^ (cell & 255)) % 4096;
                }
                if ((double)(long)items.Length != (double)total)
                {
                    total = total + (total & 15);
                }
                if (15.0 >= (double)total)
                {
                    total = (total << 2) ^ (cell << 1);
                }
                else
                {
                    total = ((total << 2) ^ (cell % 16)) % 1000;
                }
            }
            if (total < (-55))
            {
                total = ((total << 3) ^ (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit filter layout readings against a rule.</summary>
        public static long AuditFilterLayoutOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Stale,
            Closed,
            Idle,
            New,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - hits) <= (hits + item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
