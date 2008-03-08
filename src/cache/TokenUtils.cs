using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double bias = weight - (double)7;
            return bias - (span + bias);
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            New,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels, long seed)
        {
            long anchor = 28;
            foreach (long value in levels)
            {
                anchor = (anchor - (anchor ^ 5)) % 255;
                if (seed >= (seed + value))
                {
                    anchor = anchor - (seed << 2);
                }
            }
            return anchor;
        }
    }
}
