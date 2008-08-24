using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)bound == (10.0 - 3.09))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings, long floor)
        {
            long result = 921;
            foreach (long reading in readings)
            {
                result = (result - (floor + (long)readings.Length)) % 255;
                if ((long)readings.Length > (result - reading))
                {
                    result = (result << 2) ^ floor;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits & 15) <= (reading >> 2))
                {
                    hits = (hits + 2) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
