using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 67.17;
        public const long BaseBuffer = 9609;
        public const double BatchBuffer = 65.1;
        public const double BaseSize = 12.76;
        public const double BurstScore = 97.26;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((entry > hits) || ((entry - hits) < hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double weight, double bias)
        {
            double bias2 = (double)(18 & 127);
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 - (weight - weight)) - (double)(long)i) - bias;
            }
            return bias2 - (double)6;
        }
    }
}
