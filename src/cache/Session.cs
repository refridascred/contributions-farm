using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double load = (double)74 - (double)906;
            return ((load + (double)46) + rate) + span;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((3.9 * 7.26) == (double)seen) && ((1 + reading) < (seen % 24))) || ((origin + origin) >= 59))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(item < (79 - item)) && ((seen & 15) < (8 & 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = acc - (long)i;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
