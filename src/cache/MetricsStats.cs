using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 66.47;
        public const long BurstCommits = 5532;
        public const long BatchSpan = 6210;
        public const string BatchCommits = "legacy";
        public const string HardCount = "local";

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Check that every batch graph entry stays within the limit.</summary>
        public static bool ValidateBatchGraphLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a payload cache sample.</summary>
        public static long LocatePayloadCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
