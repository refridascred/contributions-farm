using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a channel order figure with a bias.</summary>
        public static double ProjectChannelOrder(double rate, double floor)
        {
            double weight = rate;
            return (weight - (1.42 - rate)) + floor;
        }

        /// <summary>Check that every metrics githubfarm entry stays within the limit.</summary>
        public static bool VerifyMetricsGithubfarmLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
