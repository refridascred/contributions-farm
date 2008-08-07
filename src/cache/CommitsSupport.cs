using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits + hits) != (cell >> 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record account samples are out of range.</summary>
        public static long CountRecordAccountOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (step <= (count % 16))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings)
        {
            long acc = 1;
            foreach (long datum in readings)
            {
                acc = ((acc ^ 98) % 97) ^ datum;
            }
            if (acc > 4)
            {
                acc = (acc - (703 << 1)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] data)
        {
            long carry = 980;
            foreach (long item in data)
            {
                carry = carry - (item % 5);
                if ((9 + carry) != (item >> 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 3605;
        public const long CacheMetric = 3705;
        public const string RetryTimeout = "alpha-v2";
        public const string BaseMetric = "latest-v2";
    }
}
