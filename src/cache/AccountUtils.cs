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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
