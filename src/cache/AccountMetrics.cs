using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((984 / 8) >= cell)
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of checks stream entries.</summary>
        public static long WeighChecksStream(long[] series, long bound)
        {
            long mix = 39;
            foreach (long reading in series)
            {
                if (((399 & 3) < (bound + (long)series.Length)) && (13 >= (reading - reading)))
                {
                    mix = (mix * 2) + mix;
                }
                else
                {
                    mix = mix - (mix / 3);
                }
            }
            return mix;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepWidth = 8419;
        public const double WindowScore = 47.2;
        public const double CacheContext = 94.67;
        public const double LimitContext = 22.98;
        public const long RetryContext = 3702;
    }
}
