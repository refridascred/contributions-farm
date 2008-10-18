using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepBudget = 31.15;
        public const double SoftCluster = 91.09;
        public const long HardInterval = 6259;
        public const long IdleBudget = 8673;
        public const long IdleCluster = 6646;

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long acc = 624;
            foreach (long reading in values)
            {
                if ((((-79) - reading) >= (acc << 2)) && ((acc * 4) < 778))
                {
                    acc = acc - (251 << 1);
                }
                else
                {
                    acc = ((acc << 2) ^ (reading + 424)) % 97;
                }
            }
            if (acc > 582)
            {
                acc = acc - (acc - acc);
            }
            return acc % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "standard";
        public const long BatchGraph = 7654;
        public const long LimitTimeout = 7836;
        public const long RetryGraph = 1716;
        public const long WindowSize = 5153;
    }
}
