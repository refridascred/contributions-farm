using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double scale = rate / 4.0;
            if (scale <= (double)281)
            {
                scale = (scale - (8.5 * 16.0)) - offset;
            }
            return scale + (rate + rate);
        }

        /// <summary>Iterate the tools format series from a seed.</summary>
        public static long RollToolsFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix - (step << 2)) % 1000;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchSize = 4096;
        public const long MinScore = 2704;
        public const string RetryCache = "open";
    }
}
