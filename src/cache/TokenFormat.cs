using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(((seen - datum) < (datum >> 2)) && ((5.33 / 6.0) <= (double)datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double weight = rate;
            return (weight + (double)242) + span;
        }
    }
}
