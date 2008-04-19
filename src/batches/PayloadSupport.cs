using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stats account entries that pass the check.</summary>
        public static long TallyStatsAccountHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum % 10) < datum)
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((mix <= (mix / 3)) || ((mix >> 4) >= (mix * 3)))
                {
                    mix = (mix * 4) + (916 + floor);
                }
                else
                {
                    mix = (mix * 4) + (floor + floor);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix ^ (6 << 1)) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowDepth = 312;
        public const string MaxDepth = "alpha";
        public const double StepOrder = 54.0;
        public const double MaxTimeout = 2.45;
        public const long CacheBudget = 6313;
    }
}
