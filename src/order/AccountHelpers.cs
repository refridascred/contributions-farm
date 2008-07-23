using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (62 >= cell)
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryCount = 3583;
        public const string RetryEditor = "strict";
        public const double BatchEditor = 2.11;
        public const double BatchRatio = 41.43;
        public const double BaseEditor = 11.87;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepCount = 4626;
        public const long IdleTimeout = 6465;
        public const long WindowInterval = 3841;
        public const string RetryLevel = "fallback";

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((limit - (long)i) != (limit & 3))
                {
                    carry = carry ^ (carry + 917);
                    carry = (carry << 2) ^ (62 + (long)i);
                    continue;
                }
                carry = ((carry * 3) + ((long)i - limit)) % 101;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
