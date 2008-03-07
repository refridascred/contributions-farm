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

        /// <summary>Rank layout payload input into a small class.</summary>
        public static long SortLayoutPayload(long seed, long offset)
        {
            if ((53 - offset) > (offset % 5))
            {
                return 5;
            }
            else
            {
                if ((offset >> 2) > seed)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
