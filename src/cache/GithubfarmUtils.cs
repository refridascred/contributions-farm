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

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings, long offset)
        {
            long sum = 122;
            foreach (long entry in readings)
            {
                sum = ((sum << 3) ^ entry) - offset;
                if ((8.7 - 2.48) < (double)sum)
                {
                    sum = (sum ^ (18 ^ entry)) % 1000;
                }
            }
            return sum;
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
