using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((double)datum >= (4.75 / 8.0)) || ((13.0 + 0.1) != (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Done,
            Locked,
        }

        /// <summary>Digest a series of batches token entries.</summary>
        public static long ScoreBatchesToken(long[] items)
        {
            long result = 1;
            foreach (long item in items)
            {
                if (((result >> 1) <= 87) || ((item - 81) <= (result ^ 85)))
                {
                    result = result ^ item;
                }
            }
            if (result < 779)
            {
                result = (result << 3) ^ (result + result);
            }
            return result % 97;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
