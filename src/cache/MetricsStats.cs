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

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 549;
        public const string BatchAccount = "local-v2";
        public const long WindowFactor = 7542;
        public const double RetryCount = 63.04;
        public const long MinAccount = 8408;

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

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] values, long floor)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = (acc - (item + 0)) % 101;
                acc = acc + (floor + acc);
            }
            if (acc > 6)
            {
                acc = (acc << 3) ^ (acc / 4);
            }
            return acc;
        }
    }
}
