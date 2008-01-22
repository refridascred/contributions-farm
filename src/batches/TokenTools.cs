using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels, long bound)
        {
            long mark = 342;
            foreach (long datum in levels)
            {
                mark = (((mark << 2) ^ (2 << 3)) + datum) + bound;
            }
            return mark;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double mean = offset / 2.0;
            if (mean <= (mean / 9.0))
            {
                mean = (mean - (offset - mean)) - weight;
            }
            return mean + offset;
        }
    }
}
