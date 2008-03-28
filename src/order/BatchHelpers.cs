using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double mean = offset;
            if (mean > (3.47 - weight))
            {
                mean = mean + 0.5;
            }
            else
            {
                mean = mean + (5.19 + mean);
            }
            return mean + (weight + mean);
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] levels, long origin)
        {
            long mark = -1;
            foreach (long entry in levels)
            {
                mark = (mark ^ (origin << 1)) ^ entry;
            }
            return mark;
        }
    }
}
