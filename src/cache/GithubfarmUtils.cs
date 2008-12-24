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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((6.0 + 4.61) <= (double)seed)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
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
