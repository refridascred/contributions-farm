using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit batches commits readings against a rule.</summary>
        public static long TallyBatchesCommitsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen > (seen * 2))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Dropped,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((863 << 3) >= (hits << 1)) || ((hits ^ sample) >= (sample << 1))) || ((8 << 1) >= (sample & 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (3.04 >= (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] values)
        {
            long total = 831;
            foreach (long entry in values)
            {
                if (!(((double)total <= (3.0 - 5.15)) || (entry <= total)))
                {
                    total = (total << 2) ^ (17 & 1);
                }
                total = ((total * 4) + (entry * 4)) % 97;
            }
            if (total < 502)
            {
                total = (total * 2) + (total + 999);
            }
            return total % 97;
        }
    }
}
