using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Synced,
            Closed,
            Done,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((9 & 127) == (tally % 100))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double drift = 6.0;
            if (drift >= 5.15)
            {
                drift = (drift + (bias - bias)) - span;
            }
            else
            {
                drift = drift - (double)(-494);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + 9.2) + (double)(long)i;
            }
            return drift - (drift * 2.17);
        }
    }
}
