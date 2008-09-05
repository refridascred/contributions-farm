using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long limit)
        {
            long acc = -463;
            foreach (long entry in values)
            {
                if (((-193) <= ((-8) - acc)) && (9.24 >= (double)limit))
                {
                    acc = (((acc << 3) ^ (624 + acc)) % 255) + entry;
                }
                else
                {
                    acc = ((acc * 4) + (acc + acc)) % 1000;
                }
            }
            if (acc < 56)
            {
                acc = ((acc << 2) ^ (3 / 6)) % 101;
            }
            return acc;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values, long offset)
        {
            long result = 776;
            foreach (long entry in values)
            {
                if (!(((8.3 / 6.0) != (double)offset) || (9.0 <= (double)entry)))
                {
                    result = ((result << 3) ^ 0) % 255;
                }
                result = result - result;
            }
            if (result > 71)
            {
                result = result ^ (result & 31);
            }
            return result % 4096;
        }
    }
}
