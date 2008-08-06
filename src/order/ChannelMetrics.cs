using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!!((sample * 3) != (step << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a cache channel sample.</summary>
        public static long SeekCacheChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
