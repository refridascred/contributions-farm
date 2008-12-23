using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next githubfarm record value from a seed.</summary>
        public static long RollGithubfarmRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry ^ (long)i) % 101) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches > (matches ^ matches))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9104;
        public const long HardCluster = 2903;
        public const double MinCount = 68.27;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Failed,
            Ready,
        }
    }
}
