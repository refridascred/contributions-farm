using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many metric graph samples are out of range.</summary>
        public static long AuditMetricGraphHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((double)tally < (7.0 - 4.0)) && ((sample >> 5) > (tally << 3)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache channel samples.</summary>
        public static long CombineCacheChannel(long[] items, long origin)
        {
            long result = 558;
            foreach (long cell in items)
            {
                result = ((result ^ (result / 5)) % 255) - cell;
            }
            if (result > 6)
            {
                result = (result - (origin >> 3)) % 65521;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 2882;
        public const long BurstWidth = 4047;
        public const double BurstRatio = 62.42;

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "fallback-v2";
        public const double StepCount = 73.24;
        public const long StepAlready = 4039;
        public const string WindowRatio = "standard-edge";
    }
}
