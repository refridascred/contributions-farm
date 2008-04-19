using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + count) > (count & 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two layout report measurements.</summary>
        public static double ProjectLayoutReport(double rate, double span)
        {
            double scale = rate;
            if (scale > span)
            {
                scale = scale + scale;
            }
            return scale - (scale + rate);
        }

        /// <summary>Check that every command counter entry stays within the limit.</summary>
        public static bool VerifyCommandCounterBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
