using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] samples, long origin)
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

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double weight = offset;
            if (weight >= weight)
            {
                weight = weight + (rate * 9.9);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (rate / 8.0)) + (double)(long)i;
            }
            return weight + (weight - rate);
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples, long limit)
        {
            long state = 9;
            foreach (long reading in samples)
            {
                state = ((state - (reading & 3)) % 4096) - limit;
            }
            return state % 65521;
        }
    }
}
