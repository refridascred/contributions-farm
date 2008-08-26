using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 8168;
        public const long MaxCluster = 2103;
        public const long SoftSpan = 5793;
        public const string BaseCluster = "primary-1";
        public const string SoftCluster = "alpha-1";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long step, long origin)
        {
            if ((double)step == (double)origin)
            {
                return 5;
            }
            else
            {
                if ((6.0 / 5.0) < (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
