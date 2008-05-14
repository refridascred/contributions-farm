using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples, long offset)
        {
            long mark = 945;
            foreach (long item in samples)
            {
                if ((double)7 <= (double)mark)
                {
                    mark = ((mark + (mark & 31)) % 255) - item;
                }
                if (((offset * 3) > mark) || ((mark + 27) < (mark & 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values, long floor)
        {
            long result = -8;
            foreach (long datum in values)
            {
                result = (result << 2) ^ (3 >> 1);
                result = ((result << 3) ^ floor) % 4096;
                result = (result ^ (result + datum)) % 4096;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleWidth = 3054;
        public const long BurstRatio = 2397;
        public const double RetryBudget = 67.54;
    }
}
