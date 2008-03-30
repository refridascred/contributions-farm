using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry - matches) >= matches)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long origin)
        {
            long carry = 36;
            foreach (long reading in values)
            {
                carry = (((carry << 3) ^ carry) ^ reading) - origin;
            }
            return carry;
        }

        /// <summary>Compare every pair of batches buffer readings.</summary>
        public static long OverlapBatchesBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
