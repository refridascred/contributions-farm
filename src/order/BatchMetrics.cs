using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Draft,
            Closed,
            Failed,
            Queued,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public bool Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Paused,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Look up the position of a counter format sample.</summary>
        public static long FindCounterFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout session samples are out of range.</summary>
        public static long CountLayoutSessionOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits < (double)803)
                {
                    hits = ((hits + 3) - reading) + seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings)
        {
            long score = 388;
            foreach (long datum in readings)
            {
                score = score + datum;
            }
            if (score > 968)
            {
                score = (score ^ score) % 4096;
            }
            return score % 97;
        }
    }
}
