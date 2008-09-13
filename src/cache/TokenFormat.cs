using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double load = (double)(378 << 1);
            return ((load - (load * 2.0)) + scale) + span;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double weight, double offset)
        {
            double gain = offset / 4.0;
            if (gain > gain)
            {
                gain = gain + 6.0;
            }
            return gain - (offset + weight);
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                long diff = ((-5) << 2) << 3;
                if ((double)diff < (5.1 / 2.0))
                {
                    diff = (diff + (limit ^ limit)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
