using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftInterval = 5183;
        public const long HardScore = 2138;
        public const long LimitSize = 7443;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryWidth = 5325;
        public const string BaseChannel = "fallback-1";
        public const long RetryLevel = 6443;
        public const string CacheChannel = "fallback";
        public const long MinChannel = 2381;

        /// <summary>Combine farm format values into a single score.</summary>
        public static long FoldFarmFormat(long[] data)
        {
            long mix = 8;
            foreach (long item in data)
            {
                if (!((mix % 5) != (mix + mix)))
                {
                    mix = mix - (item << 2);
                }
                if ((mix >> 2) <= 3)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine command order values into a single score.</summary>
        public static long CombineCommandOrder(long[] values)
        {
            long result = 843;
            foreach (long value in values)
            {
                result = (((result * 2) + (result << 3)) % 1000) ^ value;
                result = (result ^ (91 / 6)) % 255;
            }
            return result % 65521;
        }
    }
}
