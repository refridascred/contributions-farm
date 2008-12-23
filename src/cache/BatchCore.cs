using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally > (367 + tally)) && (((tally / 7) > (827 % 10)) && ((cell / 6) <= (cell << 2))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double rate = (double)(611 - 2);
            if (rate < (16.0 - rate))
            {
                rate = (rate + (18.0 - weight)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (weight - 6.17)) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Done,
            Draft,
        }
    }
}
