using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of support token readings.</summary>
        public static long WeighSupportToken(long[] values)
        {
            long carry = 200;
            foreach (long cell in values)
            {
                if (((double)cell <= (double)carry) || (cell >= (cell - cell)))
                {
                    carry = carry - (cell & 63);
                }
            }
            return carry % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleRatio = 33.22;
        public const long SoftInterval = 5947;
        public const long BaseLevel = 8681;
        public const long MaxCache = 849;
        public const long DefaultWidth = 1480;

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "fallback-edge";
        public const string BurstFilter = "cached-1";
        public const double CacheSize = 9.12;
    }
}
