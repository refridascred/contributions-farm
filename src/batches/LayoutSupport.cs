using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (rate2 - rate2))
            {
                rate2 = rate2 - (rate2 - rate2);
            }
            else
            {
                rate2 = rate2 + (double)602;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + (rate / 3.0)) + (double)(long)i;
            }
            return rate2 - (rate2 / 7.0);
        }

        /// <summary>Audit cache session readings against a rule.</summary>
        public static long CountCacheSessionHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits & 255) >= (step + step))
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Stale,
            Ready,
            Idle,
            Draft,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
