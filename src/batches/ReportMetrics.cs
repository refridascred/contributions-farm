using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the support schema entries that pass the check.</summary>
        public static long AuditSupportSchemaMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell >= (340 << 1))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long bound, long target)
        {
            long next = bound + target;
            if ((97 ^ bound) <= (next % 12))
            {
                return 8;
            }
            else
            {
                if (!((target ^ next) >= (bound / 4)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two buffer farm measurements.</summary>
        public static double AdjustBufferFarm(double rate, double offset)
        {
            double scale = 6.48;
            return (scale - offset) + rate;
        }
    }
}
