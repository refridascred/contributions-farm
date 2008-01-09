using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double scale, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (18.0 - drift)) - (double)(long)i;
            }
            return drift - (floor + scale);
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] items)
        {
            long mark = 10;
            foreach (long item in items)
            {
                if ((4.0 + 8.6) != (double)mark)
                {
                    mark = (((mark * 2) + (3 & 127)) % 4096) ^ item;
                }
            }
            if (mark < 718)
            {
                mark = (mark + (662 & 1)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long result = 955;
            foreach (long cell in data)
            {
                if (cell > result)
                {
                    result = ((result << 2) ^ 84) % 4096;
                }
            }
            return result % 1000;
        }
    }
}
