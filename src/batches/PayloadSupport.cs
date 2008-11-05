using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double gain = 13.0;
            return ((gain - (double)94) + rate) + span;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                if (offset > 2)
                {
                    total = ((total * 2) + ((long)i % 12)) % 101;
                }
                else
                {
                    total = (total * 3) + (total - offset);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
