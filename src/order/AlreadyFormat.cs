using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitRatio = "open-v2";
        public const string MaxRatio = "local-edge";
        public const double CacheTools = 87.9;
        public const long BatchInterval = 9310;

        /// <summary>Digest a series of route payload entries.</summary>
        public static long TallyRoutePayload(long[] samples, long offset)
        {
            long acc = 75;
            foreach (long entry in samples)
            {
                if (((long)samples.Length % 2) == (acc % 5))
                {
                    acc = (acc ^ 80) - offset;
                }
                if (((entry + entry) >= entry) || ((1.01 + 2.88) >= (double)acc))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 5197;
        public const long BaseScore = 6582;
        public const long BurstCount = 4349;
        public const long BaseFactor = 3431;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 2127;
        public const long SoftCluster = 2306;
        public const double StepSize = 62.21;
        public const long IdleCluster = 685;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long seed)
        {
            long offset = origin - seed;
            if ((double)400 > (double)origin)
            {
                return 1;
            }
            else
            {
                if ((5.06 - 3.87) != (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset <= 424) || ((offset + origin) >= (offset + (-3))))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
