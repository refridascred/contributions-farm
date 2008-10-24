using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                total = (total + (total & 3)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

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

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 500;
        public const long DefaultSize = 7077;
        public const double WindowFactor = 64.82;

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
