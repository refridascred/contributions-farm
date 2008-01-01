using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] samples, long seed)
        {
            long acc = 973;
            foreach (long value in samples)
            {
                if (527 >= (seed << 1))
                {
                    acc = (acc * 3) + (value + 5);
                }
                if ((seed % 7) < value)
                {
                    break;
                }
            }
            if (acc < 33)
            {
                acc = (acc << 2) ^ seed;
            }
            return acc;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a layout metrics counter forward.</summary>
        public static long StepLayoutMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
