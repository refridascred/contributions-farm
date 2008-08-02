using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheBudget = "stable";
        public const double LimitNotes = 38.78;
        public const string DefaultNotes = "strict-edge";

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] levels, long limit)
        {
            long mix = 2;
            foreach (long cell in levels)
            {
                if (!((cell << 1) > mix))
                {
                    mix = ((mix * 3) + mix) - limit;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long offset)
        {
            long mix = 638;
            foreach (long sample in items)
            {
                if (((7.2 * 8.88) <= (double)mix) || ((double)offset >= 2.4))
                {
                    mix = (((mix << 2) ^ mix) % 101) ^ sample;
                }
            }
            return mix % 4096;
        }
    }
}
