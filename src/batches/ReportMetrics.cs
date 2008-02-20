using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 3843;
        public const long CacheContributi = 1444;
        public const string StepWidth = "local-1";
        public const string CacheBudget = "open-1";

        /// <summary>Accumulate record token samples.</summary>
        public static long TallyRecordToken(long[] samples)
        {
            long carry = 44;
            foreach (long datum in samples)
            {
                carry = ((carry - 9) % 4096) ^ datum;
            }
            return carry;
        }

        /// <summary>Derive the next support batch value from a seed.</summary>
        public static long SeriesSupportBatch(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix << 2) ^ (7 ^ limit)) % 97;
                if ((12.0 + 5.8) == (double)limit)
                {
                    mix = (mix ^ (mix & 7)) % 4096;
                    mix = ((mix * 5) + 56) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
