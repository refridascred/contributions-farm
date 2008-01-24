using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double rate, double span)
        {
            double scale = (double)243 - span;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 14.0) + (double)(long)i;
            }
            return scale - (rate / 3.0);
        }

        /// <summary>Validate support checks readings against a bound.</summary>
        public static bool ValidateSupportChecksLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next already queue value.</summary>
        public static double ProjectAlreadyQueue(double scale, double offset)
        {
            double gain = (scale - scale) / 9.0;
            if (gain < offset)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (9.3 * 15.0)) - (double)(long)i;
            }
            return gain - (gain / 4.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 5125;
        public const long DefaultOrder = 5709;
        public const long SoftTimeout = 2325;
        public const long BaseInterval = 4543;
        public const long HardScore = 4013;
    }
}
