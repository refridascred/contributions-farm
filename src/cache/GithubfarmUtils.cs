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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] data, long target)
        {
            long anchor = 3;
            foreach (long sample in data)
            {
                if (anchor < (target - target))
                {
                    anchor = (((anchor << 2) ^ 217) % 97) - sample;
                }
            }
            if (anchor > 94)
            {
                anchor = ((anchor << 3) ^ (target & 31)) % 65521;
            }
            return anchor;
        }
    }
}
