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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
