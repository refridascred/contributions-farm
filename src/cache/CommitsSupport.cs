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

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchDepth = 2861;
        public const long LimitInterval = 2681;
        public const string MinRatio = "open-1";

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
