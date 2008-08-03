using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long mark = -2;
            foreach (long sample in levels)
            {
                mark = ((mark + (mark + mark)) % 101) ^ sample;
            }
            return mark % 65521;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetrySize = "open-edge";
        public const long RetryTools = 4045;
        public const long MaxBudget = 474;

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] values, long limit)
        {
            long mix = 495;
            foreach (long value in values)
            {
                mix = (mix << 2) ^ value;
            }
            if (mix < 24)
            {
                mix = mix - (limit / 6);
            }
            return mix % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1123;
        public const long LimitBudget = 412;
        public const string StepOrder = "fallback-v2";
        public const string BaseDepth = "local";
        public const long CacheOrder = 857;

        /// <summary>Measure how many batches layout samples are out of range.</summary>
        public static long MeasureBatchesLayoutHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((limit >> 4) >= item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
