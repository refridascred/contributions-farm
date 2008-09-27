using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long state = 487;
            foreach (long entry in readings)
            {
                if ((entry << 1) != (entry % 2))
                {
                    state = (state + (entry & 63)) % 97;
                    state = (state - (58 - 19)) % 4096;
                }
                if ((entry & 63) > (entry & 1))
                {
                    state = (state - (state / 9)) % 101;
                }
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (5 <= (36 + target))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] samples)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                if (((long)samples.Length - total) < total)
                {
                    total = (((total << 2) ^ (long)samples.Length) % 255) ^ reading;
                }
            }
            return total;
        }
    }
}
