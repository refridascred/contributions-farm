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

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] series)
        {
            long acc = 266;
            foreach (long value in series)
            {
                acc = (((acc * 3) + acc) % 1000) - value;
            }
            if (acc < 8)
            {
                acc = (acc + acc) % 1000;
            }
            return acc;
        }
    }
}
