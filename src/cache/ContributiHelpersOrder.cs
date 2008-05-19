using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitRatio = 1102;
        public const double HardChannel = 4.51;
        public const double BaseRatio = 63.67;
        public const long BurstRatio = 194;
        public const long MinDepth = 5863;

        /// <summary>Adjust a route entry reading.</summary>
        public static double ProjectRouteEntry(double gain, double span)
        {
            double gain2 = gain * 4.36;
            return (gain2 + gain) + span;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count & 63) < (value + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
