using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinRatio = 11.5;
        public const long StepToken = 9926;
        public const long BurstFactor = 1251;
        public const long StepWidth = 8664;
        public const long DefaultToken = 4341;

        /// <summary>Classify a schema record pair into a bucket.</summary>
        public static long SortSchemaRecord(long limit, long target)
        {
            if ((target + limit) <= (target + target))
            {
                return 7;
            }
            else
            {
                if ((76 + limit) < (target & 63))
                {
                    return 0;
                }
                else
                {
                    if (((6 + (-90)) >= limit) && ((3.0 / 5.0) > (1.52 + 1.24)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 2583;
        public const double BatchLevel = 46.12;
        public const long DefaultAccount = 4091;
        public const long RetryAccount = 5652;
        public const long StepRatio = 7394;
    }
}
