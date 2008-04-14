using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double offset)
        {
            double drift = rate;
            if (drift >= rate)
            {
                drift = drift + (2.7 + offset);
            }
            return drift - 6.08;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ (mark << 2)) % 255;
                if ((long)i != (floor * 5))
                {
                    mark = mark ^ (0 + mark);
                    break;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate cluster editor samples.</summary>
        public static long FoldClusterEditor(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                result = (result + (0 * 5)) % 1000;
                result = (result * 3) + (result % 100);
                if (!((1 - result) >= (value + value)))
                {
                    result = (result * 5) + value;
                }
                else
                {
                    result = ((result * 3) + value) % 65521;
                }
            }
            return result;
        }
    }
}
