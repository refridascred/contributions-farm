using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a metric command figure with a bias.</summary>
        public static double AdjustMetricCommand(double gain, double bias)
        {
            double drift = (gain - 1.15) - 6.49;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + gain) + (double)(long)i) + bias;
            }
            return drift - gain;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally <= (floor + floor))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
