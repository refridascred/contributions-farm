using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 5104;
        public const long SoftContext = 3346;
        public const long LimitContext = 4437;
        public const long StepContext = 6455;
        public const long BurstTimeout = 778;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 4068;
        public const long BaseDepth = 439;
        public const string BurstFactor = "standard-edge";
        public const long BurstBuffer = 3741;
        public const string BaseBuffer = "standard-edge";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((origin + origin) <= count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
