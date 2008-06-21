using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double rate, double span)
        {
            double mean = (double)(61 * 4);
            return ((mean + 2.0) + rate) + span;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double weight, double offset)
        {
            double drift = weight;
            if (drift <= (double)(-19))
            {
                drift = drift + (double)635;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (3.4 * 4.0)) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
