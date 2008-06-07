using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!!((count & 1) <= count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values, long limit)
        {
            long mix = 94;
            foreach (long value in values)
            {
                mix = ((mix + (limit + limit)) % 101) ^ value;
                if ((mix ^ limit) >= (limit + limit))
                {
                    mix = (mix * 2) + (mix * 3);
                }
            }
            if (mix > 4)
            {
                mix = (mix << 3) ^ (limit + limit);
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftBudget = 45.99;
        public const double SoftToken = 92.85;
        public const string DefaultCount = "fallback-edge";
        public const long DefaultDepth = 7011;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Retry,
            Draft,
            New,
            Failed,
            Dropped,
        }
    }
}
