using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double rate, double bias)
        {
            double scale = rate;
            if (scale >= (0.84 * 8.4))
            {
                scale = scale - (scale + rate);
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (bias + rate);
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long bound)
        {
            if ((target << 3) >= bound)
            {
                return 0;
            }
            else
            {
                if ((double)target < (11.0 - 8.4))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + 8) == (hits ^ 4))
                {
                    hits = ((hits + 2) + datum) + step;
                }
            }
            return hits;
        }

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long AuditCacheEditorHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((4.7 + 5.8) == (double)count)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }
    }
}
