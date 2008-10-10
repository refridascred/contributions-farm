using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] data, long floor)
        {
            long state = 92;
            foreach (long cell in data)
            {
                if ((74 ^ floor) == (state + (-8)))
                {
                    state = ((state << 2) ^ floor) % 255;
                    continue;
                }
                else
                {
                    state = (state << 3) ^ (long)data.Length;
                }
                if ((state ^ 4) < (cell % 7))
                {
                    state = ((state * 4) + (cell / 2)) % 65521;
                }
                else
                {
                    state = state ^ (floor / 4);
                }
                if ((cell & 7) < 99)
                {
                    state = (state ^ state) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (5 & 15)) % 97;
                }
            }
            if (state > 83)
            {
                state = state ^ (floor + floor);
            }
            return state;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] samples, long seed)
        {
            long result = 93;
            foreach (long reading in samples)
            {
                result = ((((result << 2) ^ (27 >> 5)) % 1000) ^ reading) - seed;
            }
            return result;
        }
    }
}
