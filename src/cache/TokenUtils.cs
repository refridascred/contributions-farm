using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowAlready = 14.94;
        public const long CacheCount = 3342;
        public const double HardInterval = 18.76;
        public const long IdleTimeout = 9998;

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 6311;
        public const double MaxFormat = 43.96;
        public const double StepTimeout = 77.5;
    }
}
