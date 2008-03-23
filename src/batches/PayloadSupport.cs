using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of counter session entries.</summary>
        public static long ScoreCounterSession(long[] data, long seed)
        {
            long acc = 423;
            foreach (long value in data)
            {
                acc = (acc + (seed + acc)) - value;
            }
            if (acc > 62)
            {
                acc = (acc + (seed >> 5)) % 97;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 4546;
        public const double BatchCluster = 82.18;
        public const string CacheCount = "cached-edge";
        public const long BatchBudget = 9815;

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
