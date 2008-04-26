using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate notes editor readings against a bound.</summary>
        public static bool CheckNotesEditorLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double gain = bias;
            if (gain > (weight / 2.0))
            {
                gain = gain + (bias - weight);
            }
            else
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (5.0 - bias);
        }
    }
}
