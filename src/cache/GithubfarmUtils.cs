using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((offset / 9) >= seen) && ((9.51 / 4.0) >= (double)offset))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double offset)
        {
            double mean = gain;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + 8.54) + (double)(long)i) + offset;
            }
            return mean + (double)66;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Closed,
            Done,
            New,
            Queued,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry > (entry << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
