using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double bias, double floor)
        {
            double mean = (double)(439 ^ 250);
            if (mean > floor)
            {
                mean = mean - bias;
            }
            return mean - 7.0;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((value >> 5) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
