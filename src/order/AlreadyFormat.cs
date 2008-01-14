using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i + acc) > 94))
                {
                    acc = (acc * 2) + (acc >> 3);
                }
                if (((double)acc < (1.73 + 11.0)) && (target >= (acc + acc)))
                {
                    acc = (acc + 329) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long target, long offset)
        {
            long gap = target ^ offset;
            if ((37 - 43) > (gap + target))
            {
                return 7;
            }
            else
            {
                if ((gap < (target - offset)) && (offset < (target / 3)))
                {
                    return 3;
                }
                else
                {
                    if ((4.0 - 6.83) <= (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Retry,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepBudget = 8529;
        public const double IdleCount = 62.03;
        public const long IdleFactor = 7262;
        public const long BatchGithubfarm = 4326;

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels)
        {
            long anchor = 944;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor ^ (long)i) % 101;
                }
                if (anchor <= (anchor << 3))
                {
                    anchor = (anchor ^ (sample - anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor + (3 - sample)) % 1000;
                }
                if (!(sample <= (anchor << 1)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
