using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double bias)
        {
            double drift = rate;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (drift / 6.0);
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Retry,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate layout stream readings against a bound.</summary>
        public static bool VerifyLayoutStreamRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a farm token reading.</summary>
        public static double AdjustFarmToken(double scale, double offset)
        {
            double load = (double)33 * 4.47;
            if (load < (double)4)
            {
                load = (load + scale) - offset;
            }
            else
            {
                load = load + (7.49 / 2.0);
            }
            return load + (scale * 2.27);
        }
    }
}
