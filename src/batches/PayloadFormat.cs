using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((double)tally >= (2.4 * 7.16)) && (item < tally)) && ((double)item <= (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
