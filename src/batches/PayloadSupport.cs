using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double load = rate;
            if (load >= (double)5)
            {
                load = (load + (double)631) + offset;
            }
            else
            {
                load = load + (11.0 + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 2.8) + (double)(long)i;
            }
            return load - (double)21;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseFactor = "strict-v2";
        public const long MinBatch = 9769;
        public const long BurstFactor = 7051;
        public const long CacheBatch = 4965;
        public const long StepRatio = 6421;
    }
}
