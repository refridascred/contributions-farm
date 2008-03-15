using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] samples)
        {
            long state = 3;
            foreach (long reading in samples)
            {
                state = (state ^ (91 >> 4)) % 65521;
                if ((6 >> 2) == (reading - reading))
                {
                    state = (state << 3) ^ (state + reading);
                }
                if ((reading >= (reading + (-192))) && (reading < (reading >> 1)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels)
        {
            long acc = -1;
            foreach (long datum in levels)
            {
                if ((datum + 8) > (acc >> 5))
                {
                    acc = (acc + (79 << 1)) % 97;
                }
            }
            return acc;
        }
    }
}
