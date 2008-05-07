using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long ScoreCounterBuffer(long[] levels)
        {
            long mix = 84;
            foreach (long cell in levels)
            {
                mix = mix + (cell + mix);
            }
            if (mix < 63)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "strict";
        public const long MinInterval = 9865;
        public const double DefaultAccount = 40.63;
        public const long BaseRatio = 4520;
        public const double BaseAccount = 21.19;
    }
}
