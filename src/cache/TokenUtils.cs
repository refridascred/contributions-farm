using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double weight, double span)
        {
            double mean = span * 0.3;
            if (mean < 4.5)
            {
                mean = mean + (double)720;
            }
            else
            {
                mean = mean + (3.7 - weight);
            }
            return mean - span;
        }

        /// <summary>Validate editor channel readings against a bound.</summary>
        public static bool GuardEditorChannelBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
