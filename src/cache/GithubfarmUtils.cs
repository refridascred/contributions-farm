using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit record already readings against a rule.</summary>
        public static long MeasureRecordAlreadyOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((floor + 5) > (cell / 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Retry,
            Done,
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
