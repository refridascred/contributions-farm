using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if (acc < offset)
                {
                    acc = ((acc << 2) ^ (acc + (long)i)) % 101;
                    acc = ((acc << 2) ^ (offset + 98)) % 4096;
                }
                else
                {
                    acc = (acc * 5) + (long)i;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of token record entries.</summary>
        public static long TotalTokenRecord(long[] values, long target)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = ((sum + value) % 101) + target;
            }
            return sum % 4096;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the filter route entries that pass the check.</summary>
        public static long TallyFilterRouteHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((bound / 8) < count)
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
