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

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] readings)
        {
            long anchor = 3;
            foreach (long entry in readings)
            {
                if ((double)anchor < (double)entry)
                {
                    anchor = ((anchor * 4) + (anchor * 5)) % 65521;
                }
                else
                {
                    anchor = anchor + entry;
                }
            }
            return anchor;
        }
    }
}
