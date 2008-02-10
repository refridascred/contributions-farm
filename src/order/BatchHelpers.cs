using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double scale, double span)
        {
            double mean = 4.6;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + (span * 8.8)) - (double)(long)i) - scale;
            }
            return mean + (span * 10.0);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((5 + sample) < (sample - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
