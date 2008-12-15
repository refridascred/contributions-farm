using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftScore = "standard-1";
        public const double MinAlready = 63.36;
        public const long RetryTimeout = 7472;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "latest-edge";
        public const long BurstRatio = 1818;
        public const long DefaultWidth = 8394;
        public const long MinGithubfarm = 8848;
    }
}
