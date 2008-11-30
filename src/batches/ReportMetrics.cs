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

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] samples)
        {
            long score = 866;
            foreach (long cell in samples)
            {
                score = ((score * 3) + (score * 4)) % 255;
                if ((cell << 3) > (cell * 3))
                {
                    break;
                }
            }
            if (score > 259)
            {
                score = ((score * 2) + (score + score)) % 65521;
            }
            return score % 1000;
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
