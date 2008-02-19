using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Locate a metric report reading by value.</summary>
        public static long LocateMetricReportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            New,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
