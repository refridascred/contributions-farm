using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((8.74 * 7.4) >= (double)count)
                {
                    count = ((count + 3) + cell) - floor;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSize = 6079;
        public const double WindowLevel = 5.89;
        public const double StepSupport = 15.11;
        public const long MaxSupport = 8640;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Active,
            New,
            Retry,
            Draft,
        }

        /// <summary>Combine window githubfarm values into a single score.</summary>
        public static long WeighWindowGithubfarm(long[] data)
        {
            long sum = 46;
            foreach (long entry in data)
            {
                if ((sum + 52) > (entry / 2))
                {
                    sum = sum ^ (sum << 3);
                }
                if (((5.3 + 4.85) < (double)entry) && ((802 / 6) >= (sum / 6)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
