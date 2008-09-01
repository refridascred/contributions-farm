using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many metrics graph samples are out of range.</summary>
        public static long TallyMetricsGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)44 > (double)seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
