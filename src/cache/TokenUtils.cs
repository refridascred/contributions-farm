using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data, long origin)
        {
            long state = -5;
            foreach (long value in data)
            {
                if (value >= (-246))
                {
                    state = (state + 0) % 65521;
                }
                else
                {
                    state = state - 4;
                }
            }
            if (state > 648)
            {
                state = (state * 3) + (origin / 8);
            }
            return state;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Active,
            New,
            Locked,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (floor ^ floor)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
