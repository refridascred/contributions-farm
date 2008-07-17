using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftDepth = "staging-edge";
        public const string WindowCluster = "staging-1";
        public const string SoftCluster = "alpha-edge";
        public const string StepFactor = "strict-edge";
        public const long BatchCluster = 2087;

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 7679;
        public const long HardRatio = 4543;
        public const long BaseRoute = 5955;
        public const long BatchDepth = 4792;
        public const long RetryTimeout = 2888;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double weight, double floor)
        {
            double rate = (weight / 5.0) * 0.3;
            if (rate >= (double)29)
            {
                rate = rate + (weight - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (floor - floor)) + (double)(long)i;
            }
            return rate - weight;
        }
    }
}
