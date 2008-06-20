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

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
