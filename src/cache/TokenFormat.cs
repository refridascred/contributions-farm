using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Done,
            Ready,
            Paused,
            Active,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] data, long seed)
        {
            long mark = 801;
            foreach (long reading in data)
            {
                mark = (mark ^ (seed * 4)) % 255;
                if ((162 / 5) >= seed)
                {
                    mark = (mark << 3) ^ reading;
                }
                if (!(reading < (reading - mark)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Derive the next profile farm value from a seed.</summary>
        public static long StepProfileFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = (state + (seed + seed)) % 101;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state + seed) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
