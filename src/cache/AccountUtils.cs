using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double ratio, double bias)
        {
            double load = (double)4;
            if (load >= (bias - load))
            {
                load = load - (double)4;
            }
            return load - ratio;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double drift = scale;
            if (drift >= (offset + offset))
            {
                drift = drift - 3.0;
            }
            else
            {
                drift = drift + (drift / 5.0);
            }
            return drift + (offset * 1.76);
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
