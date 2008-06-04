using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit batches githubfarm readings against a rule.</summary>
        public static long TallyBatchesGithubfarmHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample < 18.0)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepWidth = 7827;
        public const long StepSize = 443;
        public const long RetryRecord = 9814;

        /// <summary>Grade a cache record value against two limits.</summary>
        public static long BucketCacheRecord(long floor, long floor2)
        {
            if ((45 < (floor & 63)) && ((267 * 5) == (floor + floor)))
            {
                return 6;
            }
            else
            {
                if ((floor + 31) <= (744 / 6))
                {
                    return 3;
                }
                else
                {
                    if (424 <= (floor2 - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor2 == (6.0 - 3.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen & 1) != (248 + datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support contributi entries.</summary>
        public static long FoldSupportContributi(long[] samples)
        {
            long state = -729;
            foreach (long entry in samples)
            {
                if (((long)samples.Length > ((-114) >> 5)) || ((state * 3) > (state + 18)))
                {
                    state = ((state - (state >> 3)) % 1000) + entry;
                }
            }
            return state % 4096;
        }
    }
}
