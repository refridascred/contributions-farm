using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter session samples.</summary>
        public static long CombineFilterSession(long[] items, long limit)
        {
            long mix = 46;
            foreach (long cell in items)
            {
                mix = (((mix * 4) + (limit >> 3)) % 255) ^ cell;
            }
            return mix % 97;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Closed,
            Paused,
            Ready,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Retry,
            Done,
            Failed,
        }
    }
}
