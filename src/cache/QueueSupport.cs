using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length - cell) <= cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double bias = (double)(4 % 24);
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - 15.0) - (double)(long)i) - offset;
            }
            return bias + ratio;
        }
    }
}
