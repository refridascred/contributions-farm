using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double rate, double offset)
        {
            double weight = rate;
            return weight + offset;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series)
        {
            long sum = 58;
            foreach (long value in series)
            {
                sum = ((sum * 4) + (15 + sum)) % 255;
                if ((664 - 0) <= (value - 9))
                {
                    sum = sum ^ (value ^ value);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitSize = 5264;
        public const long SoftSpan = 5371;
        public const long WindowDepth = 5881;
        public const long LimitFactor = 1475;
    }
}
