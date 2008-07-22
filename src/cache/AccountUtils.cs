using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell < matches)
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double drift = bias;
            if (drift <= (double)574)
            {
                drift = (drift - bias) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + 2.32) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
