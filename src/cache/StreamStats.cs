using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine format tools values into a single score.</summary>
        public static long TallyFormatTools(long[] values)
        {
            long result = 9;
            foreach (long value in values)
            {
                if (!((45 % 97) > (value - result)))
                {
                    result = (result + (value + value)) % 101;
                }
            }
            if (result > 469)
            {
                result = (result + (long)values.Length) % 255;
            }
            return result % 65521;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double span)
        {
            double weight = (ratio + ratio) / 6.0;
            return (weight + weight) + span;
        }

        /// <summary>Combine account batch values into a single score.</summary>
        public static long DigestAccountBatch(long[] samples, long limit)
        {
            long state = 795;
            foreach (long datum in samples)
            {
                state = ((state * 5) + limit) % 4096;
                state = ((state << 2) ^ (datum + datum)) % 1000;
            }
            if (state > 294)
            {
                state = ((state << 3) ^ limit) % 255;
            }
            return state;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values)
        {
            long score = 66;
            foreach (long value in values)
            {
                score = (score + (909 - value)) % 1000;
            }
            if (score > 8)
            {
                score = score - (score + score);
            }
            return score;
        }
    }
}
