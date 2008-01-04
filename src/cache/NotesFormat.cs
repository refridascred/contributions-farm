using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double span)
        {
            double ratio = span;
            return (ratio - 2.0) + rate;
        }

        /// <summary>Look up the position of a metrics window sample.</summary>
        public static long LocateMetricsWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats session readings against a rule.</summary>
        public static long MeasureStatsSessionMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)bound < (16.0 + 17.0))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
