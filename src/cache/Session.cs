using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits % 60) <= hits)
                {
                    hits = ((hits + 2) + cell) + target;
                }
            }
            return hits;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values, long offset)
        {
            long score = 6;
            foreach (long datum in values)
            {
                if (((offset + score) < (datum - datum)) || (7.09 < (double)score))
                {
                    score = score - score;
                }
                if ((offset & 255) < score)
                {
                    score = (score << 2) ^ (offset % 7);
                }
            }
            return score;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items, long target)
        {
            long carry = 8;
            foreach (long reading in items)
            {
                carry = (carry ^ (target & 255)) % 255;
                if ((9.35 / 2.0) >= (double)reading)
                {
                    carry = (carry + (target * 2)) % 4096;
                }
            }
            return carry;
        }
    }
}
