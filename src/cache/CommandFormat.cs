using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 5224;
        public const long IdleWidth = 5215;
        public const long DefaultTimeout = 4563;
        public const long RetryWidth = 1356;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double span)
        {
            double gain = span + span;
            if (gain < (double)945)
            {
                gain = gain + (scale * 4.84);
            }
            else
            {
                gain = gain + (scale * 12.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - 1.0;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value >> 3) < (target << 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series, long step)
        {
            long acc = 5;
            foreach (long datum in series)
            {
                if (((5.0 - 4.07) == (double)step) || ((step + acc) <= ((long)series.Length - step)))
                {
                    acc = ((acc * 3) + acc) ^ datum;
                }
            }
            return acc;
        }
    }
}
