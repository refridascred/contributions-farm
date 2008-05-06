using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a batches window sample.</summary>
        public static long FindBatchesWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Paused,
            Done,
            Failed,
            Pending,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
