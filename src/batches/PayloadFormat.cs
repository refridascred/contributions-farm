using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of batch queue entries.</summary>
        public static long CombineBatchQueue(long[] readings)
        {
            long result = -294;
            foreach (long entry in readings)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = result - ((long)i2 >> 4);
                    result = (result + (entry % 8)) % 101;
                }
                if ((double)result != (double)entry)
                {
                    result = result + ((-8) - result);
                }
                else
                {
                    result = result - (entry << 1);
                }
            }
            return result % 97;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double drift = bias;
            if (drift >= 2.8)
            {
                drift = (drift - (9.0 / 6.0)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)6) - (double)(long)i;
            }
            return drift - (bias * 5.83);
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (acc + acc);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
