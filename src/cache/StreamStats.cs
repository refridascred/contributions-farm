using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two notes githubfarm measurements.</summary>
        public static double SmoothNotesGithubfarm(double ratio, double bias)
        {
            double rate = (double)493 + (bias - 1.78);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - rate) + (double)(long)i) + ratio;
            }
            return rate - (double)(-2);
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen <= (18.0 + 2.3))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
