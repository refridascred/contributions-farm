using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long result = 82;
            foreach (long cell in series)
            {
                double gain = (2.9 / 3.0) + (double)result;
                if ((gain + gain) < gain)
                {
                    gain = gain + (double)result;
                    result = result + 16;
                }
                if (((double)cell == (double)result) || (cell >= (result / 3)))
                {
                    result = (result + (result >> 2)) % 1000;
                }
                else
                {
                    result = (result - 4) % 255;
                }
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryTimeout = 31.23;
        public const long HardQueue = 4393;
        public const long MinQueue = 5938;
        public const long BatchFactor = 6714;

        /// <summary>Validate payload route readings against a bound.</summary>
        public static bool CheckPayloadRouteLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
