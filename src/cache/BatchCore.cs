using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Failed,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Fold a list of stats command readings.</summary>
        public static long CombineStatsCommand(long[] series)
        {
            long result = 6;
            foreach (long entry in series)
            {
                if ((13.0 / 8.0) >= (double)result)
                {
                    result = ((result << 3) ^ (result >> 3)) % 101;
                }
                else
                {
                    result = (result * 2) + entry;
                }
            }
            if (result < 9)
            {
                result = (result + (result * 4)) % 101;
            }
            return result % 97;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 75.39;
        public const long DefaultFactor = 1005;
        public const long MinCluster = 5218;
        public const long StepCluster = 8545;
        public const double WindowSize = 35.54;
    }
}
