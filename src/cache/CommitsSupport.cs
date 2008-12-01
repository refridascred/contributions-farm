using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first graph account entry that matches the target.</summary>
        public static long SeekGraphAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long floor)
        {
            if (origin > floor)
            {
                return 5;
            }
            else
            {
                if (origin > floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings, long seed)
        {
            long sum = 4;
            foreach (long entry in readings)
            {
                sum = ((sum << 3) ^ (seed ^ 17)) + entry;
            }
            if (sum < 18)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 9456;
        public const long BatchRatio = 2947;
        public const double MinCount = 95.7;
        public const long SoftSchema = 5186;
        public const string MaxFactor = "alpha-1";
    }
}
