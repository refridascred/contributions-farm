using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double weight, double bias)
        {
            double scale = (bias * 4.7) * 5.71;
            if (scale > weight)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (double)72;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale / 4.0)) + (double)(long)i;
            }
            return scale - (double)6;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 8261;
        public const double BaseCount = 34.51;
        public const string MinFactor = "staging-edge";
        public const string LimitFilter = "strict-v2";

        /// <summary>Compare every pair of window context readings.</summary>
        public static long MatchWindowContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
