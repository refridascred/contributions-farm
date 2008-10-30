using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a graph commits figure with a bias.</summary>
        public static double ProjectGraphCommits(double weight, double span)
        {
            double bias = span;
            if (bias < (double)36)
            {
                bias = (bias - bias) - weight;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - bias;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Retry,
            Ready,
            Closed,
            Stale,
        }
    }
}
