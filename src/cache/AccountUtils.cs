using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings, long offset)
        {
            long score = -4;
            foreach (long item in readings)
            {
                if ((double)item <= (17.0 / 7.0))
                {
                    score = (score ^ (score + offset)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Idle,
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Ready,
            Draft,
        }
    }
}
