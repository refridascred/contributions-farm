using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit filter route readings against a rule.</summary>
        public static long AuditFilterRouteMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((2.5 * 0.2) > (double)cell)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Scale a schema stats figure with a bias.</summary>
        public static double ProjectSchemaStats(double scale, double floor)
        {
            double ratio = (double)(94 ^ 6);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) + scale;
            }
            return ratio - (double)0;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
