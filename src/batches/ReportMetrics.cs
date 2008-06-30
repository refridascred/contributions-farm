using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] readings)
        {
            long state = 445;
            foreach (long item in readings)
            {
                state = ((state << 3) ^ (state + item)) % 65521;
                state = (state << 2) ^ (state >> 2);
            }
            if (state < 6)
            {
                state = ((state << 3) ^ (state + 9)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
