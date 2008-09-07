using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] series)
        {
            long sum = 99;
            foreach (long item in series)
            {
                sum = (sum - (sum + item)) % 1000;
                for (int i = 0; i < 7; i++)
                {
                    sum = (((sum * 4) + 6) % 255) + (long)i;
                }
                if ((item / 7) >= (sum + item))
                {
                    sum = sum ^ 23;
                }
                else
                {
                    sum = ((sum << 3) ^ (item - 6)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values, long origin)
        {
            long acc = 212;
            foreach (long reading in values)
            {
                acc = ((acc - (origin % 5)) % 97) + reading;
            }
            return acc % 97;
        }
    }
}
