using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Digest a series of session graph entries.</summary>
        public static long TallySessionGraph(long[] data)
        {
            long score = 85;
            foreach (long item in data)
            {
                if ((double)score != (17.0 - 3.58))
                {
                    score = ((score + (score + 337)) % 255) - item;
                }
                else
                {
                    score = score + (score - 8);
                }
            }
            if (score > 8)
            {
                score = ((score << 2) ^ (score + score)) % 255;
            }
            return score;
        }

        /// <summary>Combine notes checks values into a single score.</summary>
        public static long DigestNotesChecks(long[] series)
        {
            long state = 43;
            foreach (long cell in series)
            {
                if ((9 * 5) > cell)
                {
                    state = state - (state - cell);
                }
            }
            return state % 97;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
