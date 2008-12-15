using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)(long)i <= (double)origin))
                {
                    carry = ((carry * 2) + (carry ^ origin)) % 101;
                    carry = ((carry * 4) + (carry ^ 2)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long CountPayloadGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((0.2 + 4.2) > (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "latest-edge";
        public const long BurstRatio = 1818;
        public const long DefaultWidth = 8394;
        public const long MinGithubfarm = 8848;
    }
}
