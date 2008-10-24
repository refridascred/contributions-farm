using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchWidth = 3605;
        public const double CacheLayout = 94.89;
        public const long BaseLayout = 9728;
        public const double CacheCount = 38.56;
        public const long RetryScore = 9808;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally & 31) > (tally << 2))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Token { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] readings)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ (datum >> 1)) % 97;
                if (((-69) - datum) < anchor)
                {
                    anchor = (anchor ^ (datum + anchor)) % 65521;
                    anchor = (anchor << 3) ^ (80 * 4);
                }
                if (1.35 < (double)datum)
                {
                    anchor = anchor ^ (543 >> 1);
                }
            }
            return anchor % 1000;
        }
    }
}
