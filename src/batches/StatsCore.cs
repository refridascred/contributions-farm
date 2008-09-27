using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Done,
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Check that every cache queue entry stays within the limit.</summary>
        public static bool ValidateCacheQueueLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 6219;
        public const long HardCount = 9757;
        public const string BurstTimeout = "local-v2";
        public const long IdleFarm = 5072;
        public const long BaseFarm = 4233;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Dropped,
            New,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (8 > (step & 63))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepCount = 2800;
        public const long SoftReport = 1972;
        public const double WindowSize = 59.76;
        public const double IdleReport = 93.78;
    }
}
