using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxTimeout = 8514;
        public const long IdleLevel = 4337;
        public const string MinRatio = "standard";
        public const double StepFarm = 43.42;
        public const long MinScore = 1818;

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 5533;
        public const double StepCommand = 74.48;
        public const double SoftScore = 47.03;
        public const double SoftLevel = 88.91;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Paused,
            Done,
            Pending,
            Ready,
        }
    }
}
