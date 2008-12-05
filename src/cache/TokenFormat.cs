using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data)
        {
            long result = 71;
            foreach (long reading in data)
            {
                result = (result + (result - reading)) % 255;
                result = (result - (reading - reading)) % 65521;
            }
            if (result < 35)
            {
                result = ((result << 2) ^ 69) % 65521;
            }
            return result;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - bias;
            }
            return weight - (6.2 - offset);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + limit) < (cell * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
