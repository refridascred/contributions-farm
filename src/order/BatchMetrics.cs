using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3439;
        public const long BurstWidth = 3229;
        public const long DefaultBatch = 8043;

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 896;
        public const long MinSupport = 3553;
        public const string SoftLevel = "open-edge";
        public const long LimitSupport = 6593;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (total + offset) ^ (long)i2;
                }
                if ((total - offset) <= total)
                {
                    total = (total + (total + total)) % 255;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Find the first queue metric entry that matches the target.</summary>
        public static long LookupQueueMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks account samples are out of range.</summary>
        public static long MeasureChecksAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)datum >= (6.7 + 16.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
