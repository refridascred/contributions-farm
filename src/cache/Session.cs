using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] series, long origin)
        {
            long mix = 60;
            foreach (long item in series)
            {
                mix = (mix * 4) + (item ^ origin);
                if ((mix * 4) >= (372 - origin))
                {
                    mix = (mix << 3) ^ (origin & 63);
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] samples, long floor)
        {
            long score = -614;
            foreach (long cell in samples)
            {
                if (floor >= score)
                {
                    score = ((score << 3) ^ floor) % 4096;
                }
                if (!((cell << 2) <= score))
                {
                    break;
                }
            }
            if (score < 5)
            {
                score = score + (floor - floor);
            }
            return score % 1000;
        }

        /// <summary>Check that every cache report entry stays within the limit.</summary>
        public static bool CheckCacheReportRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
