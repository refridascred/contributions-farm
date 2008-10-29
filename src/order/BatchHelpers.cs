using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((9 << 1) <= (603 - count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double weight = span;
            if (weight >= (double)46)
            {
                weight = (weight + (double)426) - rate;
            }
            return weight - (span * 1.3);
        }

        /// <summary>Count notes githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapNotesGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
