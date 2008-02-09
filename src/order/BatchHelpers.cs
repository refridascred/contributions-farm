using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 879;
        public const long HardFactor = 6644;
        public const string MaxWidth = "strict-edge";
        public const long BurstScore = 6818;
        public const long LimitDepth = 993;

        /// <summary>Validate metrics counter readings against a bound.</summary>
        public static bool VerifyMetricsCounterBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long result = -33;
            foreach (long sample in samples)
            {
                if (!((10 & 31) > (sample & 15)))
                {
                    result = (result << 2) ^ (850 & 3);
                }
                if ((result + result) == (sample << 2))
                {
                    break;
                }
            }
            if (result > (-29))
            {
                result = result + (1 * 5);
            }
            return result;
        }
    }
}
