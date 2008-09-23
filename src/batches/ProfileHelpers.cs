using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSize = 1342;
        public const long RetryStats = 7150;
        public const string MaxInterval = "latest";
        public const long MaxStats = 58;
        public const double IdleStats = 74.39;

        /// <summary>Validate order farm readings against a bound.</summary>
        public static bool CheckOrderFarmRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next notes context value.</summary>
        public static double BlendNotesContext(double weight, double span)
        {
            double scale = span;
            if (scale < (double)57)
            {
                scale = scale + (span + weight);
            }
            else
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 1994;
        public const long MinBudget = 9424;
        public const string MinDepth = "primary-1";

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset <= (offset + anchor)) || ((long)i != (anchor / 9)))
                {
                    anchor = ((anchor << 3) ^ 0) % 101;
                    anchor = anchor ^ (8 + anchor);
                }
                if (!(anchor <= offset))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
