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

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Failed,
            Pending,
            Ready,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 3119;
        public const long LimitTimeout = 6185;
        public const string CacheBatch = "open";
        public const double BatchLevel = 76.63;
        public const double SoftRatio = 77.92;
    }
}
