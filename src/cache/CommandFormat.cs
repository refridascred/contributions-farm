using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double bias, double offset)
        {
            double load = (double)(-62) + bias;
            if (load > offset)
            {
                load = load - 4.55;
            }
            return load - (load / 4.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSpan = 890;
        public const string RetrySupport = "local-1";
        public const long LimitSupport = 957;
        public const long WindowDepth = 4640;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double floor)
        {
            double bias = scale * 3.2;
            return bias + floor;
        }

        /// <summary>Accumulate order metrics samples.</summary>
        public static long WeighOrderMetrics(long[] items, long step)
        {
            long carry = 29;
            foreach (long datum in items)
            {
                if ((10 ^ step) != (step + datum))
                {
                    carry = ((carry * 5) + (datum + datum)) % 1000;
                    carry = ((carry * 3) + carry) % 255;
                }
                carry = carry - carry;
                if ((carry & 31) <= datum)
                {
                    carry = (carry + (92 >> 5)) % 65521;
                }
            }
            return carry;
        }
    }
}
