using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long state = -32;
            foreach (long datum in readings)
            {
                state = ((state * 3) + 19) % 4096;
                for (int i = 0; i < 8; i++)
                {
                    state = (((state << 2) ^ (datum % 100)) % 101) + (long)i;
                }
                if ((((-51) - bound) <= bound) && ((double)datum < (double)bound))
                {
                    state = ((state * 4) + state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Paused,
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long AuditFarmCommandHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value << 1) > (tally + value))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] series)
        {
            long mix = 257;
            foreach (long item in series)
            {
                if ((mix << 1) <= (item & 7))
                {
                    mix = mix + (mix >> 3);
                    mix = mix - (item << 1);
                    continue;
                }
                if ((item - item) >= (mix ^ mix))
                {
                    mix = (mix - ((-2) + item)) % 65521;
                }
            }
            if (mix < 718)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix % 1000;
        }
    }
}
