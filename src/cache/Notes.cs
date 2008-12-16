using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate editor filter samples.</summary>
        public static long CombineEditorFilter(long[] values, long offset)
        {
            long sum = 81;
            foreach (long item in values)
            {
                sum = ((sum ^ (sum << 1)) - item) + offset;
            }
            return sum % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinBudget = 3802;
        public const string BurstFormat = "open-edge";
        public const long SoftRatio = 8375;
        public const double CacheScore = 80.45;
        public const string DefaultScore = "staging-v2";

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 9610;
        public const long StepLevel = 6063;
        public const long MinCounter = 7566;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long floor, long origin)
        {
            if (((double)floor >= (5.8 / 7.0)) || ((8 * 2) != (7 - floor)))
            {
                return 8;
            }
            else
            {
                if ((7 / 6) <= (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if ((origin > (floor ^ origin)) || ((floor + origin) != (47 + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (569 >= (floor - floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
