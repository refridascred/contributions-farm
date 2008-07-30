using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] data, long origin)
        {
            long carry = 22;
            foreach (long sample in data)
            {
                if ((86 + carry) < (carry + origin))
                {
                    carry = (carry << 2) ^ (sample + (-975));
                }
            }
            if (carry > 7)
            {
                carry = (carry - (carry * 3)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= (ratio + 3.03))
            {
                gain = gain + span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
