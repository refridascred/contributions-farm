using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long MeasureEntryChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((387 <= (tally - datum)) && (((double)datum > 7.41) && ((3 * 5) >= tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double drift = offset;
            if (drift >= (double)748)
            {
                drift = drift - (double)(-37);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + (2.0 - scale);
        }
    }
}
