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

        /// <summary>Match up buffer layout samples.</summary>
        public static long CompareBufferLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
