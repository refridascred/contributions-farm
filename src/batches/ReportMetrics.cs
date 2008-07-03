using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long result = 962;
            foreach (long reading in levels)
            {
                if ((result <= ((-547) + result)) && ((result << 2) <= reading))
                {
                    result = result - (reading - result);
                }
            }
            return result % 65521;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double weight, double span)
        {
            double mean = span;
            if (mean <= (mean - mean))
            {
                mean = mean + 9.22;
            }
            else
            {
                mean = mean + (double)8;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (2.0 * 5.17)) + (double)(long)i;
            }
            return mean + (weight * 11.0);
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Draft,
            Ready,
            Done,
        }
    }
}
