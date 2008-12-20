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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long anchor = 79;
            foreach (long datum in series)
            {
                if ((datum + anchor) <= anchor)
                {
                    anchor = (anchor - datum) % 101;
                }
            }
            if (anchor < 860)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor % 97;
        }
    }
}
