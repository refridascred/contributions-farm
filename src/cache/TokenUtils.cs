using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples)
        {
            long mix = 429;
            foreach (long datum in samples)
            {
                if (((8.0 + 1.6) >= (double)datum) && ((9.1 / 6.0) > (double)mix))
                {
                    mix = ((mix << 2) ^ (datum + mix)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Find the first metric notes entry that matches the target.</summary>
        public static long FindMetricNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session command value from a seed.</summary>
        public static long RollSessionCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = (result + (limit << 2)) % 1000;
                result = ((result * 3) + (2 + limit)) % 101;
                if (((long)i + limit) <= (8 << 2))
                {
                    result = (result + (5 << 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
