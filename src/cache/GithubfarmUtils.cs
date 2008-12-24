using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine format batch values into a single score.</summary>
        public static long CombineFormatBatch(long[] values)
        {
            long total = 798;
            foreach (long entry in values)
            {
                total = (total * 4) + (entry + entry);
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepRatio = 1135;
        public const long MinLevel = 2458;
        public const long CacheTools = 1852;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                long next = origin & 7;
                next = (next - sum) % 101;
                sum = (sum << 3) ^ (next - sum);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
