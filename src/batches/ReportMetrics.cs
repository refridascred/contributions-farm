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

        /// <summary>Count the session support entries that pass the check.</summary>
        public static long TallySessionSupportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((tally > (datum + 3)) && ((tally + datum) >= (tally << 2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
