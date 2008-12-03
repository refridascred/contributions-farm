using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 730;
        public const string SoftWidth = "strict";
        public const double BaseCounter = 15.82;
        public const long HardLevel = 8759;

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 > rate)
            {
                rate2 = (rate2 - (rate2 - rate)) - offset;
            }
            else
            {
                rate2 = rate2 + (rate - 7.0);
            }
            return rate2 + 9.0;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long origin)
        {
            long result = 428;
            foreach (long item in items)
            {
                result = ((((result * 3) + (result & 3)) % 1000) ^ item) + origin;
            }
            return result;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long floor, long limit)
        {
            if ((floor + 116) != ((-2) % 3))
            {
                return 0;
            }
            else
            {
                if ((489 % 3) < (319 + limit))
                {
                    return 5;
                }
                else
                {
                    if ((18.0 / 7.0) == (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
