using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading << 2) >= (7 ^ 448))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the support session entries that pass the check.</summary>
        public static long AuditSupportSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((1.0 / 6.0) > (double)count) || !((double)datum < (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double scale, double offset)
        {
            double rate = 9.0;
            return ((rate - (double)41) + scale) + offset;
        }
    }
}
