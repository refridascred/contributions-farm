using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double ratio = (double)(25 % 24);
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + gain) + (double)(long)i) - floor;
            }
            return ratio - gain;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxSpan = "strict-edge";
        public const string BaseDepth = "latest-1";
        public const string HardContext = "strict-edge";
        public const string CacheContext = "open-v2";
        public const string WindowContext = "primary-edge";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
