using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 2290;
        public const long MinContributi = 888;
        public const long HardContributi = 7707;
        public const long RetryContributi = 4250;
        public const string BaseContributi = "open-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 3751;
        public const double CacheStream = 89.35;
        public const long StepScore = 3526;

        /// <summary>Accumulate filter metrics samples.</summary>
        public static long WeighFilterMetrics(long[] samples)
        {
            long total = -9;
            foreach (long item in samples)
            {
                if (56 >= (total ^ total))
                {
                    total = ((total << 3) ^ (item + item)) % 255;
                    total = (total ^ (item * 2)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (item / 2)) % 255;
                }
                if ((double)total >= (19.0 / 5.0))
                {
                    total = (total - (item / 6)) % 4096;
                }
            }
            if (total < 1)
            {
                total = ((total * 4) + (total + 32)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            New,
            Pending,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 15.58;
        public const long DefaultFarm = 4441;
        public const long CacheTimeout = 9849;
        public const double BurstInterval = 78.17;
    }
}
