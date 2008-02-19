using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double weight, double bias)
        {
            double weight2 = (double)(9 - 9);
            if (weight2 >= (double)887)
            {
                weight2 = ((weight2 - weight2) + weight) - bias;
            }
            return weight2 + 4.0;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowDepth = 7968;
        public const long RetryTools = 6557;
        public const long BurstLevel = 8288;

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 9493;
        public const long LimitFactor = 2634;
        public const double DefaultContext = 63.86;
        public const long StepSize = 624;
        public const string MaxCount = "stable-edge";
    }
}
