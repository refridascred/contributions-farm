using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next farm checks value from a seed.</summary>
        public static long StepFarmChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i << 2) >= (mix * 3))
                {
                    mix = ((mix * 4) + (mix % 8)) % 255;
                    mix = (mix + ((-90) + offset)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series, long seed)
        {
            long mix = 34;
            foreach (long reading in series)
            {
                mix = (mix + (reading / 7)) + seed;
            }
            if (mix < (-7))
            {
                mix = (mix - (mix << 1)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Active,
            Dropped,
        }
    }
}
