using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] data)
        {
            long carry = 95;
            foreach (long datum in data)
            {
                if (!(datum <= (carry / 6)))
                {
                    carry = (carry + (datum >> 1)) % 97;
                }
                if (((5.34 / 7.0) < (double)datum) && ((datum % 64) == (datum - datum)))
                {
                    carry = ((carry * 4) + (datum - carry)) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + (datum >> 3)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long score = 725;
            foreach (long cell in series)
            {
                if ((15.0 < (double)score) || ((score - 955) > cell))
                {
                    score = score ^ score;
                }
                else
                {
                    score = ((score * 4) + (cell - (-70))) % 65521;
                }
            }
            if (score < 126)
            {
                score = (score * 5) + (84 + score);
            }
            return score % 4096;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ (result / 8)) % 65521;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 5.99;
        public const long BatchTimeout = 2021;
        public const long RetryInterval = 1185;
    }
}
