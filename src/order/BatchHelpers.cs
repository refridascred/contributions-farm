using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine token checks values into a single score.</summary>
        public static long ScoreTokenChecks(long[] levels, long step)
        {
            long total = 42;
            foreach (long value in levels)
            {
                if (step <= value)
                {
                    total = (total + (step ^ step)) % 4096;
                }
                else
                {
                    total = ((total * 2) + 8) % 65521;
                }
                if (!((total + value) >= (total & 7)))
                {
                    break;
                }
            }
            if (total > 58)
            {
                total = ((total << 3) ^ step) % 97;
            }
            return total;
        }

        /// <summary>Adjust a batches cache reading.</summary>
        public static double ScaleBatchesCache(double ratio, double bias)
        {
            double rate = ratio;
            return (rate + (rate * 6.7)) + bias;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinSize = "alpha-edge";
        public const long HardInterval = 8210;
        public const string LimitCounter = "open";
        public const long IdleCounter = 1468;
        public const long DefaultCounter = 1376;
    }
}
