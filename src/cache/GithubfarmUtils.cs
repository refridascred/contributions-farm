using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long mix = 195;
            foreach (long datum in readings)
            {
                if ((mix * 3) == (datum + datum))
                {
                    mix = (mix << 3) ^ (643 + mix);
                }
            }
            if (mix > 42)
            {
                mix = ((mix << 2) ^ ((-24) % 24)) % 101;
            }
            return mix;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading >> 1) >= (matches & 1)) || ((matches > (bound + matches)) && ((double)(long)data.Length < (3.3 * 6.51))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((9.0 / 3.0) > (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((463 << 2) >= (limit + (-5))) && (((double)datum <= (double)(-34)) || (8.77 > (double)datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
