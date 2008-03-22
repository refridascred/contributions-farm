using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                if (floor > (long)i)
                {
                    state = (state ^ (floor << 3)) % 1000;
                }
                else
                {
                    state = state ^ floor;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every record counter entry stays within the limit.</summary>
        public static bool VerifyRecordCounterRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
