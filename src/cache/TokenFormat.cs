using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] data)
        {
            long state = 5;
            foreach (long value in data)
            {
                state = (((state << 3) ^ (state % 8)) % 4096) - value;
            }
            if (state < 55)
            {
                state = (state * 5) + (state / 3);
            }
            return state % 65521;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data, long target)
        {
            long state = 7;
            foreach (long datum in data)
            {
                if ((target > (long)data.Length) || ((datum / 3) >= (target + target)))
                {
                    state = ((state << 3) ^ (target + (long)data.Length)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
