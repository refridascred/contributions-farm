using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] samples)
        {
            long score = 73;
            foreach (long cell in samples)
            {
                if ((double)cell > (5.12 / 9.0))
                {
                    score = (score * 3) + (score + score);
                }
            }
            if (score > 25)
            {
                score = (score * 5) + (score / 4);
            }
            return score;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] values)
        {
            long mark = 35;
            foreach (long cell in values)
            {
                mark = (mark + mark) % 255;
                if (((cell - (long)values.Length) == (cell + (long)values.Length)) && ((mark - mark) >= cell))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] readings, long seed)
        {
            long anchor = -85;
            foreach (long cell in readings)
            {
                if ((seed << 3) >= 430)
                {
                    anchor = (((anchor << 3) ^ (764 % 24)) % 97) + cell;
                }
            }
            if (anchor > 59)
            {
                anchor = ((anchor << 2) ^ (seed - 33)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 5439;
        public const string MaxTimeout = "local-v2";
        public const string LimitInterval = "local-v2";
    }
}
