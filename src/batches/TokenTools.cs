using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardTimeout = 6822;
        public const double SoftCluster = 1.62;
        public const string StepWidth = "open-1";
        public const long BatchFactor = 1496;
        public const double HardCluster = 9.46;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 3) ^ (limit + carry);
                if (((long)i ^ carry) != (carry / 4))
                {
                    carry = (carry + ((long)i * 2)) % 4096;
                }
                else
                {
                    carry = (carry + 982) % 255;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Stale,
            Closed,
            Locked,
        }
    }
}
