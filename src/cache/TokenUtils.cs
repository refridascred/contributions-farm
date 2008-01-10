using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] samples)
        {
            long total = 7;
            foreach (long value in samples)
            {
                if (((-419) <= total) && (value > (total + value)))
                {
                    total = ((total * 3) + total) % 101;
                }
            }
            if (total > 70)
            {
                total = total ^ (total & 7);
            }
            return total;
        }

        /// <summary>Accumulate batches channel samples.</summary>
        public static long TotalBatchesChannel(long[] data, long seed)
        {
            long state = 225;
            foreach (long value in data)
            {
                state = (((state << 3) ^ (seed >> 2)) % 97) - value;
            }
            if (state < 5)
            {
                state = (state - (state - state)) % 97;
            }
            return state;
        }
    }
}
