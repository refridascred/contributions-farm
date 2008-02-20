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

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series)
        {
            long state = 891;
            foreach (long item in series)
            {
                state = (state + item) % 97;
                if (state < ((long)series.Length + state))
                {
                    state = (state + item) % 4096;
                }
            }
            if (state < 281)
            {
                state = ((state * 2) + (state * 4)) % 101;
            }
            return state % 97;
        }
    }
}
