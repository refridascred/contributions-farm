using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] values, long offset)
        {
            long score = 14;
            foreach (long sample in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (score ^ sample) ^ (long)i;
                    score = (score + (sample << 1)) % 97;
                }
                if ((sample % 24) < (sample + (-3)))
                {
                    score = ((score << 3) ^ (score + offset)) % 101;
                }
                if ((score >= sample) && ((score - 2) < (8 * 2)))
                {
                    break;
                }
            }
            if (score < 853)
            {
                score = (score ^ (long)values.Length) % 4096;
            }
            return score;
        }

        /// <summary>Derive the next counter layout value from a seed.</summary>
        public static long DeriveCounterLayout(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((score + limit) >= limit)
                {
                    score = (score * 4) + score;
                }
                else
                {
                    score = ((score * 4) + ((long)i + 447)) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double weight, double span)
        {
            double mean = (weight * 8.4) + span;
            if (mean < mean)
            {
                mean = mean + 1.0;
            }
            return mean + span;
        }
    }
}
