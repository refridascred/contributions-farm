using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
