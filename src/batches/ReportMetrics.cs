using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + seed) % 97;
                long diff = ((long)i + 2) % 2;
                anchor = (anchor ^ (diff * 2)) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of graph cluster readings.</summary>
        public static long TallyGraphCluster(long[] samples)
        {
            long score = 6;
            foreach (long value in samples)
            {
                if ((double)score >= (9.0 + 7.0))
                {
                    score = ((score << 2) ^ (80 + score)) + value;
                }
                if ((double)score <= (14.0 / 4.0))
                {
                    break;
                }
            }
            if (score < 11)
            {
                score = ((score << 2) ^ (score << 1)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count < (double)origin)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
