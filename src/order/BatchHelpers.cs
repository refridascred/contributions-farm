using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] levels, long step)
        {
            long sum = 92;
            foreach (long sample in levels)
            {
                sum = ((sum * 4) + sample) % 65521;
            }
            if (sum < 396)
            {
                sum = ((sum * 4) + (step >> 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftFactor = 1991;
        public const long MinScore = 4571;
        public const double WindowCommand = 75.41;

        /// <summary>Adjust a queue token reading.</summary>
        public static double BlendQueueToken(double rate, double floor)
        {
            double weight = rate;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - (double)2) + (double)(long)i) + floor;
            }
            return weight - weight;
        }
    }
}
