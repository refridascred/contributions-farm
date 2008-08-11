using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((double)item < (2.42 - 19.0)) && ((49 * 5) <= (item - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] levels)
        {
            long anchor = 908;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (entry / 7)) % 4096;
                if (((double)entry < (6.8 - 2.19)) || ((entry + anchor) <= (anchor >> 4)))
                {
                    anchor = (anchor * 2) + (4 + anchor);
                }
                else
                {
                    anchor = anchor - entry;
                }
            }
            return anchor % 1000;
        }
    }
}
