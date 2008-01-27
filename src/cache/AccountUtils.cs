using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double span)
        {
            double gain2 = span;
            if (gain2 > (double)99)
            {
                gain2 = (gain2 + (double)32) - gain;
            }
            else
            {
                gain2 = gain2 - span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + span) + (double)(long)i;
            }
            return gain2 - (gain2 * 6.2);
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double scale, double offset)
        {
            double scale2 = 8.3;
            if (scale2 < scale)
            {
                scale2 = (scale2 + 5.0) - offset;
            }
            return scale2 + (scale / 8.0);
        }

        /// <summary>Validate counter context readings against a bound.</summary>
        public static bool VerifyCounterContextLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
