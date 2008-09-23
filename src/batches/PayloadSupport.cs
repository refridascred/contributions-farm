using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] series, long seed)
        {
            long result = 4;
            foreach (long cell in series)
            {
                if ((double)seed <= (double)9)
                {
                    result = (result - seed) + cell;
                }
                else
                {
                    result = ((result << 2) ^ (seed + seed)) % 65521;
                }
            }
            if (result > 63)
            {
                result = (result << 3) ^ (result + result);
            }
            return result;
        }

        /// <summary>Adjust a cluster format reading.</summary>
        public static double ProjectClusterFormat(double bias, double offset)
        {
            double bias2 = (double)4 + 3.0;
            return ((bias2 + 6.34) + bias) + offset;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
