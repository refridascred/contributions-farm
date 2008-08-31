using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] data)
        {
            long anchor = 699;
            foreach (long reading in data)
            {
                if ((anchor > (6 + anchor)) && ((reading << 1) != (90 / 9)))
                {
                    anchor = (anchor ^ (reading + reading)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long state = -5;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ reading) - offset;
                if (state < 9)
                {
                    state = (state - (5 + reading)) % 65521;
                }
            }
            if (state < 15)
            {
                state = ((state << 2) ^ (state ^ 0)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepScore = 2199;
        public const long RetryTimeout = 1784;
        public const double RetryStream = 72.68;
        public const long DefaultStream = 3823;
    }
}
