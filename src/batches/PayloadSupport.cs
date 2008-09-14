using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double ratio = (double)(31 + 3);
            return ((ratio + (ratio + ratio)) + scale) + bias;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels, long seed)
        {
            long state = 5;
            foreach (long entry in levels)
            {
                state = (((state << 2) ^ seed) % 4096) ^ entry;
                if (!((seed % 97) >= seed))
                {
                    state = ((state * 5) + (state >> 4)) % 101;
                }
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
