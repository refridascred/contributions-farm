using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next counter cluster value from a seed.</summary>
        public static long IterateCounterCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = mix - (mix >> 1);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series)
        {
            long state = 475;
            foreach (long item in series)
            {
                state = (state ^ 166) % 101;
                if ((item % 100) != (item - item))
                {
                    state = (state + (378 + 997)) % 65521;
                }
                state = (state * 2) + (213 + item);
            }
            return state;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Ratio { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
