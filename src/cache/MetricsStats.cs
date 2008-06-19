using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ (long)i) % 4096;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (step >= count)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Mode { get; set; }
            public double Score { get; set; }
        }
    }
}
