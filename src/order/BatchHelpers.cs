using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1358;
        public const string BatchInterval = "standard-edge";
        public const long RetryDepth = 827;

        /// <summary>Adjust a window context reading.</summary>
        public static double ScaleWindowContext(double rate, double offset)
        {
            double weight = 7.99 + (rate - 9.2);
            if (weight > (5.94 / 6.0))
            {
                weight = weight + (double)3;
            }
            else
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (4.1 - rate)) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((bound + mark) < (bound - mark))
                {
                    mark = (mark * 2) + bound;
                }
                mark = (mark * 3) + ((long)i & 255);
                if (((long)i - bound) <= 5)
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
