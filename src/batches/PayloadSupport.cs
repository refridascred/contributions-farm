using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit metrics record readings against a rule.</summary>
        public static long MeasureMetricsRecordGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((346 - hits) < hits)
                {
                    hits = ((hits + 2) - value) - step;
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long seed)
        {
            long result = 66;
            foreach (long item in readings)
            {
                if ((92 % 12) < seed)
                {
                    result = (((result * 5) + (seed + 212)) % 255) ^ item;
                }
            }
            if (result < 767)
            {
                result = ((result << 3) ^ (result + seed)) % 1000;
            }
            return result % 65521;
        }
    }
}
