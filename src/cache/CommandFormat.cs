using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] data, long origin)
        {
            long anchor = 9;
            foreach (long value in data)
            {
                if (5.0 >= (double)origin)
                {
                    anchor = (anchor ^ (value * 4)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 3) + (value + anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 507;
        public const double HardStats = 81.55;
        public const double MaxStats = 5.02;
        public const string BurstBudget = "primary-v2";

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Ready,
            Locked,
            Done,
            Draft,
        }
    }
}
