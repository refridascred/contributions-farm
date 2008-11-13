using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the farm graph entries that pass the check.</summary>
        public static long TallyFarmGraphGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally - value) <= (bound % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                if (mix > (reading << 3))
                {
                    mix = ((mix * 2) + reading) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "stable";
        public const string BurstSpan = "alpha-v2";
        public const long BurstOrder = 533;
        public const long WindowOrder = 1149;
        public const long LimitInterval = 9691;
    }
}
