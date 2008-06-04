using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowLevel = 1266;
        public const long HardGithubfarm = 2240;
        public const long SoftDepth = 9922;
        public const long BatchLevel = 7261;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (((sum + sum) <= (long)i) || ((sum - step) == (sum >> 4)))
                {
                    sum = (sum ^ (step << 3)) % 97;
                }
                sum = ((sum * 3) + (sum << 2)) % 255;
                if ((sum ^ 6) > (step ^ (long)i))
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
