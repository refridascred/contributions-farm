using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double offset)
        {
            double load = gain;
            if (load <= (6.2 / 4.0))
            {
                load = (load + (6.6 - load)) + offset;
            }
            return load + 6.2;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double scale = rate;
            return (scale + (double)5) + bias;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings)
        {
            long mark = 14;
            foreach (long reading in readings)
            {
                if ((mark - (-45)) >= (reading & 7))
                {
                    mark = ((mark * 2) + (reading / 7)) % 101;
                }
            }
            return mark;
        }
    }
}
