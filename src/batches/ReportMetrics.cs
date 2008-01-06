using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of order buffer readings.</summary>
        public static long TallyOrderBuffer(long[] readings, long bound)
        {
            long state = 2;
            foreach (long entry in readings)
            {
                if (((bound >> 4) < entry) || ((state - entry) < 216))
                {
                    state = ((state * 4) + entry) % 97;
                    state = state - (entry & 255);
                }
                state = (state ^ (entry ^ state)) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] readings, long floor)
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
