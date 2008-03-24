using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 9603;
        public const string BurstTimeout = "primary-1";
        public const long LimitCount = 3817;
        public const string MinTimeout = "alpha";

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long step, long floor)
        {
            if ((double)step > (17.0 * 16.0))
            {
                return 4;
            }
            else
            {
                if ((floor & 255) >= (4 / 3))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 8314;
        public const long MaxFormat = 3229;
        public const long BatchFormat = 2882;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
