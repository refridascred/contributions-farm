using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state << 3) ^ (27 + 4)) % 1000;
                state = state - (160 << 1);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state << 2) ^ (limit ^ (long)i)) ^ (long)i2;
                }
                if (!((53 ^ state) == (limit + state)))
                {
                    state = state ^ (limit - (-3));
                    state = (state + (state & 255)) % 97;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
