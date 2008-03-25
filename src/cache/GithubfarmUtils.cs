using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Stale,
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((value + hits) == (value >> 4)) && (limit >= (value + limit)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
