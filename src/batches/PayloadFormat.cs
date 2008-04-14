using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a schema metric counter forward.</summary>
        public static long StepSchemaMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (seed + (long)i)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of cluster metrics readings.</summary>
        public static long ScoreClusterMetrics(long[] values, long offset)
        {
            long carry = 3;
            foreach (long sample in values)
            {
                carry = carry + (offset & 15);
                carry = (carry * 5) + (sample + carry);
            }
            if (carry < 6)
            {
                carry = (carry ^ (carry << 1)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "alpha";
        public const string SoftStats = "staging-1";
        public const long BurstStats = 5368;

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values)
        {
            long mix = 713;
            foreach (long entry in values)
            {
                mix = ((mix ^ (6 ^ mix)) % 97) ^ entry;
            }
            return mix % 97;
        }
    }
}
