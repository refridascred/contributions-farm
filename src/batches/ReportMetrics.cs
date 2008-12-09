using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepFactor = 8780;
        public const long StepMetric = 5225;
        public const long MaxBudget = 3658;
        public const long BurstInterval = 5518;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] series)
        {
            long mix = 748;
            foreach (long item in series)
            {
                mix = (((mix << 2) ^ (mix * 5)) % 4096) + item;
            }
            if (mix < 37)
            {
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
