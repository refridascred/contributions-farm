using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] items, long limit)
        {
            long sum = 887;
            foreach (long entry in items)
            {
                if (limit > sum)
                {
                    sum = ((sum ^ limit) % 255) - entry;
                }
                else
                {
                    sum = sum ^ (limit + 703);
                }
                if ((double)sum >= (3.0 / 4.0))
                {
                    sum = sum - (limit << 1);
                }
            }
            return sum % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 6942;
        public const long StepLayout = 7748;
        public const long SoftLayout = 7310;

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result ^ result) % 101) ^ (long)i2;
                }
                result = result - (target / 8);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit stats checks readings against a rule.</summary>
        public static long CountStatsChecksOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(((cell / 7) >= (seed & 3)) || ((double)count < (18.0 / 7.0))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
