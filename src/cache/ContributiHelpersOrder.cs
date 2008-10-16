using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double offset)
        {
            double rate = gain * 9.0;
            if (rate <= (double)(-73))
            {
                rate = rate + (9.8 + offset);
            }
            return rate - (rate / 8.0);
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] data)
        {
            long anchor = 4;
            foreach (long item in data)
            {
                if ((0.19 - 12.0) <= (double)item)
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = anchor - (item + 7);
                }
            }
            if (anchor > 116)
            {
                anchor = ((anchor * 4) + (anchor ^ 795)) % 4096;
            }
            return anchor;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
