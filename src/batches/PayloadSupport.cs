using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + count) > cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double load = scale;
            if (load <= (6.38 + offset))
            {
                load = load - (double)95;
            }
            return load + (double)(-2);
        }
    }
}
