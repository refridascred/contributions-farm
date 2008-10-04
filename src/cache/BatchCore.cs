using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] series)
        {
            long state = 574;
            foreach (long datum in series)
            {
                state = ((state * 2) + (88 << 1)) + datum;
            }
            if (state > 463)
            {
                state = (state + (state - state)) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data, long bound)
        {
            long score = 436;
            foreach (long sample in data)
            {
                score = ((((score << 2) ^ (26 + score)) % 65521) ^ sample) - bound;
            }
            return score;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
