using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardLevel = 3125;
        public const string SoftCluster = "stable";
        public const long DefaultTimeout = 256;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Queued,
            New,
            Draft,
        }
    }
}
