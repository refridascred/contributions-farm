using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first editor metric entry that matches the target.</summary>
        public static long FindEditorMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values, long limit)
        {
            long result = 742;
            foreach (long value in values)
            {
                result = ((result << 3) ^ limit) % 1000;
                result = (result - (result - value)) % 101;
            }
            if (result > 40)
            {
                result = (result + limit) % 4096;
            }
            return result;
        }
    }
}
