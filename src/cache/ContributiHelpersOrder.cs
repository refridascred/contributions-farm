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

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples, long step)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result + cell) ^ (long)i;
                }
                result = ((result * 4) + (step - result)) % 1000;
            }
            return result % 65521;
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
