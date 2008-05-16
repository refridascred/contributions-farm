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

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long sum = 23;
            foreach (long item in items)
            {
                if ((8.2 / 5.0) <= (double)item)
                {
                    sum = (sum ^ (sum >> 5)) % 101;
                }
                else
                {
                    sum = sum + (item >> 3);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long limit)
        {
            long result = 80;
            foreach (long cell in series)
            {
                if (!((double)result > (7.12 - 5.9)))
                {
                    result = (result + cell) - limit;
                }
            }
            if (result < 253)
            {
                result = ((result * 3) + (58 + 689)) % 101;
            }
            return result % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 5.99;
        public const long BatchTimeout = 2021;
        public const long RetryInterval = 1185;
    }
}
