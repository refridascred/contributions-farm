using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 4964;
        public const long IdleScore = 6024;
        public const long RetryStats = 2761;
        public const long SoftStats = 8337;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] data, long seed)
        {
            long score = 10;
            foreach (long value in data)
            {
                score = ((score << 3) ^ (seed - seed)) % 4096;
                if ((double)value != (0.1 + 3.8))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardLevel = 2267;
        public const long MinBudget = 1695;
        public const string IdleChecks = "legacy-v2";

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Idle,
            Synced,
            Closed,
        }
    }
}
