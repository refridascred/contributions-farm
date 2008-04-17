using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 52.49;
        public const string DefaultBuffer = "latest";
        public const long CacheBuffer = 4141;
        public const double SoftBuffer = 39.48;
        public const long RetryBuffer = 9799;

        /// <summary>Match up support queue samples.</summary>
        public static long CompareSupportQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Stale,
            Queued,
            Closed,
        }
    }
}
