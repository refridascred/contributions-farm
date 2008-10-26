using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] values, long seed)
        {
            long total = 95;
            foreach (long entry in values)
            {
                if ((double)entry != (11.0 * 3.0))
                {
                    total = (total - seed) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Check that every checks batch entry stays within the limit.</summary>
        public static bool CheckChecksBatchRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double gain, double floor)
        {
            double scale = (gain + gain) - (2.28 / 7.0);
            return (scale - (gain + scale)) + floor;
        }
    }
}
