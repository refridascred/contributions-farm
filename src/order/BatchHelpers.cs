using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a entry route reading by value.</summary>
        public static long LookupEntryRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Dropped,
            Done,
            Idle,
            Locked,
        }
    }
}
