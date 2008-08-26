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

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 3862;
        public const long HardInterval = 9338;
        public const long BaseCount = 6374;
        public const string LimitLevel = "primary-v2";
        public const long BaseCommand = 4486;

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
