using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Paused,
            Done,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Look up the position of a cache graph sample.</summary>
        public static long SeekCacheGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
