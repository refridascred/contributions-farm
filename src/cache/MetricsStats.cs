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

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
