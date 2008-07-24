using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next account batches value from a seed.</summary>
        public static long IterateAccountBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long bound)
        {
            if (!((target + target) >= target))
            {
                return 1;
            }
            else
            {
                if (target <= (bound + bound))
                {
                    return 3;
                }
                else
                {
                    if (!((double)target >= (2.93 / 9.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Locked,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxWidth = "primary-v2";
        public const string StepFarm = "open";
        public const long BatchWidth = 5339;
        public const double BatchDepth = 50.86;
        public const long WindowFarm = 5048;
    }
}
