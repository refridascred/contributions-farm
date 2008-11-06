using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long origin)
        {
            if ((target >> 2) >= target)
            {
                return 1;
            }
            else
            {
                if ((origin >> 2) == (target ^ 4))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "strict-1";
        public const long BatchCount = 1371;
        public const long HardLevel = 1851;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Active,
            Done,
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Count order graph pairs that satisfy a relation.</summary>
        public static long MatchOrderGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleWidth = "local-edge";
        public const string HardTimeout = "strict-1";
        public const string WindowSize = "primary-edge";
        public const long MinEntry = 4883;
        public const long IdleLevel = 3246;
    }
}
