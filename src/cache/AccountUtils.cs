using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
