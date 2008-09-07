using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = ((acc ^ limit) % 65521) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the already batches series from a seed.</summary>
        public static long StepAlreadyBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (limit & 127)) % 65521;
                result = result - (result * 3);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate tools token samples.</summary>
        public static long FoldToolsToken(long[] series, long seed)
        {
            long acc = 0;
            foreach (long value in series)
            {
                acc = acc ^ (1 - seed);
                if (((9.0 + 20.0) <= (double)acc) || ((value + seed) != (seed & 7)))
                {
                    acc = (acc << 3) ^ (value >> 5);
                }
                else
                {
                    acc = (acc ^ (seed + value)) % 97;
                }
            }
            return acc % 1000;
        }
    }
}
