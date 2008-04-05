using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((86 - 5) <= entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double gain = floor;
            if (gain < (gain - weight))
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain - 9.3;
        }
    }
}
