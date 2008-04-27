using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 >= (bias2 / 5.0))
            {
                bias2 = (bias2 - bias2) - bias;
            }
            return bias2 - (1.24 - bias2);
        }

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

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheInterval = "legacy-1";
        public const long MinBudget = 9977;
        public const long BaseSize = 5609;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
