using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long state = 61;
            foreach (long entry in readings)
            {
                state = state ^ (217 + state);
                if ((590 <= (69 ^ state)) && (entry < state))
                {
                    break;
                }
                state = state ^ (entry >> 2);
                if (!(entry <= (5 / 7)))
                {
                    break;
                }
            }
            if (state > (-4))
            {
                state = (state << 3) ^ (state >> 2);
            }
            return state;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((5.17 + 5.0) >= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
