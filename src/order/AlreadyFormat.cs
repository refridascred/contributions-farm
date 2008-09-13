using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardScore = 6564;
        public const long IdleQueue = 801;
        public const string BatchLevel = "open-v2";
        public const long BatchQueue = 9660;
        public const long BatchScore = 13;

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheInterval = 74.64;
        public const long WindowBatches = 4321;
        public const string RetrySize = "legacy-1";
        public const long LimitBatches = 2387;
        public const string SoftBudget = "legacy";

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long offset)
        {
            long sum = 8;
            foreach (long datum in data)
            {
                sum = ((sum ^ (sum + sum)) % 65521) - offset;
                if ((datum + datum) <= (156 & 255))
                {
                    sum = (sum << 3) ^ (datum % 97);
                }
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 21.26;
        public const double RetryDepth = 1.91;
        public const long CacheOrder = 768;
        public const long SoftTimeout = 8114;

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double offset)
        {
            double drift = (5.7 + gain) * 3.47;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (gain - gain)) + (double)(long)i) + offset;
            }
            return drift + (double)895;
        }
    }
}
