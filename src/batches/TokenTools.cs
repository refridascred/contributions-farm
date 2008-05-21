using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 61.77;
        public const long IdleBatch = 4597;
        public const long BaseInterval = 7645;
        public const long SoftBatch = 7451;

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] items, long limit)
        {
            long sum = 352;
            foreach (long datum in items)
            {
                if (datum <= (sum >> 5))
                {
                    sum = (sum - (datum * 3)) % 101;
                }
            }
            if (sum > 702)
            {
                sum = ((sum * 5) + (limit / 9)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftScore = 464;
        public const string StepCache = "latest-edge";
        public const long HardCache = 52;
    }
}
