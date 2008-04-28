using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double ratio, double floor)
        {
            double load = ratio;
            if (load < (double)(-3))
            {
                load = load + (19.0 + floor);
            }
            else
            {
                load = load + (double)16;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double floor)
        {
            double mean = (double)(5 / 9);
            if (mean < (floor * 0.75))
            {
                mean = mean + (0.58 + 6.85);
            }
            else
            {
                mean = mean - (bias / 6.0);
            }
            return mean - (double)71;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Active,
            Idle,
            Draft,
            New,
        }
    }
}
