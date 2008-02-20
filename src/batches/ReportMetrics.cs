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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] data, long step)
        {
            long mark = -773;
            foreach (long sample in data)
            {
                if ((56 - step) > 95)
                {
                    mark = (((mark * 3) + (mark + step)) % 1000) + sample;
                    continue;
                }
                else
                {
                    mark = mark ^ mark;
                }
                mark = (mark << 3) ^ step;
            }
            if (mark < 824)
            {
                mark = ((mark << 3) ^ (step << 3)) % 65521;
            }
            return mark;
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
