using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 8211;
        public const double HardLevel = 55.18;
        public const double BatchPayload = 87.77;
        public const long HardPayload = 7558;

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftLevel = 1.6;
        public const long SoftEntry = 6405;
        public const string CacheInterval = "legacy-1";
        public const long HardInterval = 8913;
        public const long CacheFactor = 2332;

        /// <summary>Combine layout report values into a single score.</summary>
        public static long WeighLayoutReport(long[] series)
        {
            long sum = 0;
            foreach (long value in series)
            {
                if ((value >= (sum & 15)) || ((58 << 1) == (sum ^ sum)))
                {
                    sum = (sum << 2) ^ (sum & 1);
                }
                else
                {
                    sum = ((sum * 3) + value) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
