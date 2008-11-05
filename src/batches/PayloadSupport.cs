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

        /// <summary>Match up cache command samples.</summary>
        public static long CompareCacheCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
