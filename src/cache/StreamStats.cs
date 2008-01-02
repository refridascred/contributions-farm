using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((step % 2) < tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double ratio, double span)
        {
            double drift = (20.0 + ratio) / 6.0;
            if (drift <= (double)725)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (ratio / 3.0)) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
