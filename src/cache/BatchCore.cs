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

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double rate, double bias)
        {
            double load = rate;
            if (load < bias)
            {
                load = load + 9.82;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load - (bias + load);
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
