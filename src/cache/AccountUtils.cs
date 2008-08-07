using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series)
        {
            long mark = 66;
            foreach (long reading in series)
            {
                if ((mark + (-147)) < reading)
                {
                    mark = (mark * 5) + (5 ^ reading);
                }
                else
                {
                    mark = (mark + (mark & 7)) % 101;
                }
            }
            return mark;
        }
    }
}
