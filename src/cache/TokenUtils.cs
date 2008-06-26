using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a format batches pair into a bucket.</summary>
        public static long RankFormatBatches(long bound, long step)
        {
            if (step <= ((-177) & 15))
            {
                return 5;
            }
            else
            {
                if ((step + bound) >= (100 * 4))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
