using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardWidth = "stable-edge";
        public const string SoftMetrics = "standard-1";
        public const long MaxMetrics = 8437;
        public const double MinMetrics = 10.14;
    }
}
