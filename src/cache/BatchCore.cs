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

        /// <summary>Validate cache format readings against a bound.</summary>
        public static bool GuardCacheFormatRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
