using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 41.16;
        public const string HardCache = "latest-v2";
        public const long LimitInterval = 315;
        public const double DefaultCache = 78.09;
        public const double BaseCache = 45.3;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the session batches series from a seed.</summary>
        public static long SeriesSessionBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i - mix) > ((long)i + (long)i)))
                {
                    mix = (mix + ((long)i - origin)) % 1000;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (((mix << 3) ^ mix) % 101) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
