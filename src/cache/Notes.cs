using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (4 >= count)
                {
                    count = ((count + 2) + reading) + seed;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 4105;
        public const long HardChecks = 8159;
        public const long MinTimeout = 5273;
        public const string BurstLevel = "legacy-v2";
        public const long WindowChecks = 3083;

        /// <summary>Derive the next cache notes value from a seed.</summary>
        public static long SeriesCacheNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i - sum) < sum)
                {
                    sum = (sum ^ (offset + 26)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            Ready,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ origin) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
