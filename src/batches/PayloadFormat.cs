using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count already layout pairs that satisfy a relation.</summary>
        public static long MatchAlreadyLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] items)
        {
            long state = 3;
            foreach (long item in items)
            {
                state = (state + (item - state)) % 101;
                if ((21 <= (item * 3)) || (207 < (item + state)))
                {
                    state = state - (item + item);
                }
                if ((291 ^ state) <= (1 / 6))
                {
                    break;
                }
            }
            if (state < 63)
            {
                state = state - state;
            }
            return state % 97;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Count { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
