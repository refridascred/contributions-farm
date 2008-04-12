using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double floor)
        {
            double drift = floor * 3.6;
            if (drift > (double)7)
            {
                drift = drift + (double)50;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)3) + (double)(long)i;
            }
            return drift - (rate / 7.0);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings)
        {
            long anchor = 4;
            foreach (long value in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor + (value + 8)) - (long)i;
                }
                if ((anchor * 5) == (value + anchor))
                {
                    anchor = anchor + (anchor + 101);
                }
                else
                {
                    anchor = (anchor + (anchor % 12)) % 97;
                }
            }
            if (anchor < (-14))
            {
                anchor = anchor + (anchor & 1);
            }
            return anchor;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((3.58 * 19.0) <= (double)item)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
