using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if ((7 << 3) < (anchor * 2))
                {
                    anchor = anchor ^ (long)i;
                }
                if ((anchor + anchor) <= (anchor - anchor))
                {
                    anchor = (anchor ^ ((long)i << 1)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels)
        {
            long anchor = 392;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 5) + (sample - anchor)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double rate2 = rate + floor;
            if (rate2 >= rate2)
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (rate2 + rate2)) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}
