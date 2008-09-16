using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardFactor = 29.24;
        public const long IdleSpan = 7016;
        public const long DefaultLevel = 7043;
        public const long WindowMetrics = 2397;
        public const long BaseLevel = 9676;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            New,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Locked,
            Paused,
            Done,
        }

        /// <summary>Compare every pair of layout schema readings.</summary>
        public static long OverlapLayoutSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm commits counter forward.</summary>
        public static long StepGithubfarmCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (((sum << 3) ^ (origin << 1)) % 255) + (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
