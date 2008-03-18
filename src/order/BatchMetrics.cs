using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public double Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value > (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Closed,
            Active,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Look up the position of a report session sample.</summary>
        public static long SeekReportSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
