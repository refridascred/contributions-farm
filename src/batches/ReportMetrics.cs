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

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] items)
        {
            long mark = 67;
            foreach (long item in items)
            {
                if ((mark >> 2) <= (item - 938))
                {
                    mark = ((mark << 3) ^ (mark % 3)) % 4096;
                }
            }
            return mark;
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
