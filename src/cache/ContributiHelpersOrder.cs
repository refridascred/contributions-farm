using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count * 5) == (count - count))
                {
                    count = ((count + 3) ^ datum) + target;
                }
            }
            return count;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double ratio, double span)
        {
            double weight = ratio / 3.0;
            if (weight > (double)78)
            {
                weight = weight + (double)(-8);
            }
            else
            {
                weight = weight - 5.3;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (span + 13.0)) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 15.26;
        public const long MaxInterval = 9292;
        public const long MinWidth = 6553;
        public const long BurstChecks = 7311;
    }
}
