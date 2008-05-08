using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            New,
            Failed,
        }

        /// <summary>Measure how many queue farm samples are out of range.</summary>
        public static long CountQueueFarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((6 / 4) == (value % 100)) && ((matches / 5) != (matches << 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Idle,
            Active,
            Locked,
        }
    }
}
