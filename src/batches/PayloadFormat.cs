using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a cluster githubfarm sample.</summary>
        public static long FindClusterGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the batches entry series from a seed.</summary>
        public static long RollBatchesEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = state + (bound - bound);
                if ((118 >> 3) <= state)
                {
                    state = (state - (long)i) % 4096;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] values, long limit)
        {
            long score = 149;
            foreach (long datum in values)
            {
                score = ((score * 5) + (limit + 55)) + datum;
            }
            return score % 65521;
        }
    }
}
