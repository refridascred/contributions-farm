using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every commits editor entry stays within the limit.</summary>
        public static bool CheckCommitsEditorRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Paused,
            Pending,
            Synced,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 5956;
        public const long SoftSize = 2734;
        public const long RetryBuffer = 6165;
        public const long BurstBuffer = 2649;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Pending,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitFactor = 35.72;
        public const long IdleWidth = 5119;
        public const long BurstCommits = 127;
        public const long MinCommits = 7242;
    }
}
