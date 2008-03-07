using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetrySpan = 5062;
        public const long CacheSpan = 7318;
        public const string MinContributi = "alpha-edge";
        public const double MaxContributi = 0.3;
        public const long SoftDepth = 2516;

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double rate, double span)
        {
            double gain = rate;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + rate) + (double)(long)i) - span;
            }
            return gain - rate;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long target)
        {
            long span = limit - target;
            if ((double)span >= (3.85 - 6.7))
            {
                return 7;
            }
            else
            {
                if ((68 ^ 73) < (target & 15))
                {
                    return 2;
                }
                else
                {
                    if ((907 > (limit + limit)) || ((span ^ target) > (669 & 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
