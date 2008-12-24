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

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples)
        {
            long mark = 6;
            foreach (long cell in samples)
            {
                if (((4.0 / 6.0) >= (double)cell) && ((mark >> 1) < cell))
                {
                    mark = ((mark << 3) ^ ((long)samples.Length % 24)) % 255;
                }
                else
                {
                    mark = (mark - (cell + 91)) % 101;
                }
            }
            if (mark < 6)
            {
                mark = (mark + (mark - mark)) % 255;
            }
            return mark % 97;
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
