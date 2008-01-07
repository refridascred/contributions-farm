using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) > (sample & 255))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] items)
        {
            long carry = 470;
            foreach (long cell in items)
            {
                carry = ((carry * 4) + cell) % 65521;
                carry = (carry * 3) + (cell + carry);
            }
            return carry;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardFactor = 837;
        public const string BatchStream = "strict-1";
        public const double BurstRatio = 97.61;

        /// <summary>Count the graph context entries that pass the check.</summary>
        public static long AuditGraphContextMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((1.7 / 7.0) == (double)datum)
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }
    }
}
