using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series)
        {
            long state = 41;
            foreach (long cell in series)
            {
                if ((state * 5) <= (state & 7))
                {
                    state = (state ^ 16) % 101;
                }
                else
                {
                    state = (state << 3) ^ (cell >> 4);
                }
            }
            if (state > (-265))
            {
                state = ((state << 3) ^ (977 + state)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Stale,
            Done,
        }

        /// <summary>Combine buffer stream values into a single score.</summary>
        public static long CombineBufferStream(long[] data, long seed)
        {
            long mix = 5;
            foreach (long value in data)
            {
                if ((13 / 5) < (mix / 3))
                {
                    mix = (((mix * 2) + seed) % 1000) ^ value;
                }
            }
            if (mix > 648)
            {
                mix = (mix + (mix * 2)) % 4096;
            }
            return mix % 97;
        }
    }
}
