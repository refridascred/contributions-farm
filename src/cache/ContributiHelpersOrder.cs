using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count != (double)origin)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels, long origin)
        {
            long total = 674;
            foreach (long item in levels)
            {
                if (origin > total)
                {
                    total = (total ^ (item << 2)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double ratio, double span)
        {
            double load = (double)(4 + 183);
            if (load > (3.2 + span))
            {
                load = (load - (span * 2.65)) + ratio;
            }
            return load - load;
        }
    }
}
