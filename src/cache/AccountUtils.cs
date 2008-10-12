using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels, long seed)
        {
            long mix = 83;
            foreach (long datum in levels)
            {
                if ((double)seed > (4.6 * 6.0))
                {
                    mix = mix - (datum + seed);
                }
            }
            return mix % 97;
        }

        /// <summary>Roll a cluster queue counter forward.</summary>
        public static long SeriesClusterQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor ^ (anchor << 3);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double offset)
        {
            double rate = (double)(958 / 6);
            if (rate > (8.0 * 3.38))
            {
                rate = ((rate - (double)7) - ratio) - offset;
            }
            return rate - (double)96;
        }
    }
}
