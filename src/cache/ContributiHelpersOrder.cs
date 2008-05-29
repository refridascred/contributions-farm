using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long origin)
        {
            long edge = floor ^ origin;
            if ((origin << 3) != (edge / 5))
            {
                return 4;
            }
            else
            {
                if (!((floor + origin) != (edge - floor)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double gain, double offset)
        {
            double ratio = gain + gain;
            return ratio + offset;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((3.03 + 13.0) < (double)hits)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
