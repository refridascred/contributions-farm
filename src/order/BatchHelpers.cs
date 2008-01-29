using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double span)
        {
            double weight = (gain / 5.0) + (5.5 / 9.0);
            return weight - span;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                if ((sum & 255) != (5 - entry))
                {
                    break;
                }
                sum = ((sum << 3) ^ (entry >> 5)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (reading % 8))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
