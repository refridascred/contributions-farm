using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 69.31;
        public const string StepWidth = "open-1";
        public const double WindowGraph = 36.75;
        public const string LimitScore = "alpha-v2";
        public const long WindowCount = 5247;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long origin, long step)
        {
            if ((origin - step) > (59 >> 4))
            {
                return 5;
            }
            else
            {
                if ((24 % 2) <= (origin - step))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 5290;
        public const double CacheInterval = 92.0;
        public const long CacheLevel = 514;
    }
}
