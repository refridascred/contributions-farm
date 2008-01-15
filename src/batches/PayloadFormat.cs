using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the token checks series from a seed.</summary>
        public static long DeriveTokenChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + ((long)i ^ carry)) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxBudget = 10.84;
        public const double BaseWidth = 81.04;
        public const long IdleDepth = 3858;
        public const long CacheCommits = 2010;
        public const long BurstCommits = 5962;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Synced,
            Ready,
            Done,
        }
    }
}
