using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitTimeout = 1263;
        public const long StepWidth = 17;
        public const double MaxCounter = 8.47;
        public const double BaseTimeout = 72.53;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            New,
            Queued,
            Active,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Count metrics record pairs that satisfy a relation.</summary>
        public static long OverlapMetricsRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
