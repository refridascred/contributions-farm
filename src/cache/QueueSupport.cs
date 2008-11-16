using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((6.0 / 9.0) < (double)target) && ((53 ^ hits) <= (hits - target)))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((cell << 2) < target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double drift = (double)(7 - 403);
            if (drift <= span)
            {
                drift = drift - (3.34 / 2.0);
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (span + gain);
        }
    }
}
