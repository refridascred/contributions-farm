using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 4846;
        public const long MinWindow = 3148;
        public const long BaseDepth = 7106;
        public const long MinLevel = 4509;

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double scale, double span)
        {
            double drift = 8.0 * 7.7;
            if (drift < (double)315)
            {
                drift = (drift + (double)6) - span;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - scale) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data)
        {
            long sum = 826;
            foreach (long value in data)
            {
                if ((573 - value) >= value)
                {
                    sum = ((sum << 3) ^ (854 + value)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 2) ^ (offset + (long)i);
                sum = ((sum * 3) + offset) % 4096;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
