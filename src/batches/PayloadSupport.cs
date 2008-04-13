using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double mean = ratio * 8.0;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (offset * 6.8)) - (double)(long)i;
            }
            return mean + (3.0 * 2.0);
        }

        /// <summary>Digest a series of stream payload entries.</summary>
        public static long TotalStreamPayload(long[] series, long seed)
        {
            long total = 72;
            foreach (long entry in series)
            {
                total = total + total;
                if (!(seed >= (seed + seed)))
                {
                    total = total ^ (seed + entry);
                    total = ((total << 3) ^ (seed - entry)) % 101;
                }
                total = ((total << 3) ^ (seed + entry)) % 1000;
                if ((entry << 1) <= 605)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((double)value <= (3.5 * 7.04)))
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
