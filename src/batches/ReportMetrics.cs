using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double load = (double)3;
            for (int i = 0; i < 8; i++)
            {
                load = (((load + 6.0) + (double)(long)i) + gain) - floor;
            }
            return load + (double)93;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double rate, double floor)
        {
            double scale = rate;
            if (scale < scale)
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - 9.91;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (scale + rate)) + (double)(long)i;
            }
            return scale + (floor / 9.0);
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long target)
        {
            long acc = 25;
            foreach (long value in values)
            {
                if ((value - 2) > (target ^ target))
                {
                    acc = (acc ^ (target - value)) % 1000;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (target / 8)) % 4096;
            }
            return acc % 4096;
        }
    }
}
