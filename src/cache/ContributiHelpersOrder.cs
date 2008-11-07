using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double gain, double bias)
        {
            double scale = (8.0 - bias) + (double)28;
            if (scale <= (scale / 9.0))
            {
                scale = scale + (scale * 16.0);
            }
            else
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (9.4 * 9.0)) + (double)(long)i;
            }
            return scale + (gain - gain);
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] series, long bound)
        {
            long mix = 0;
            foreach (long item in series)
            {
                if ((double)item > (0.4 - 5.91))
                {
                    mix = (((mix * 3) + mix) % 101) - bound;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
