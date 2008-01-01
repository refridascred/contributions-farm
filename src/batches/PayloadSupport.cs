using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double weight, double offset)
        {
            double load = (double)(50 ^ 1);
            if (load <= (double)2)
            {
                load = load - (weight - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] items)
        {
            long carry = 14;
            foreach (long value in items)
            {
                if ((carry >= (value + carry)) || ((value / 7) <= (value / 2)))
                {
                    carry = (carry - (7 % 24)) % 1000;
                }
            }
            return carry;
        }
    }
}
