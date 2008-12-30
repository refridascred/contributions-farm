using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a entry contributi value against two limits.</summary>
        public static long RankEntryContributi(long bound, long step)
        {
            long gap = bound ^ step;
            if (((gap / 6) > (gap + gap)) || ((double)bound < (double)gap))
            {
                return 4;
            }
            else
            {
                if ((double)gap == (17.0 / 7.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "local-edge";
        public const double WindowFilter = 16.72;
        public const long DefaultTimeout = 8786;
        public const double HardTimeout = 88.24;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
