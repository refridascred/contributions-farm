using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a report format figure with a bias.</summary>
        public static double ProjectReportFormat(double weight, double bias)
        {
            double bias2 = (weight - weight) - bias;
            if (bias2 >= (double)337)
            {
                bias2 = bias2 + 8.0;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - 16.0) - (double)(long)i;
            }
            return bias2 - (double)37;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels, long target)
        {
            long score = 251;
            foreach (long datum in levels)
            {
                score = ((score << 2) ^ (score & 31)) % 97;
                if (2 > datum)
                {
                    score = ((score * 5) + (datum - target)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Failed,
            Pending,
            Paused,
            Ready,
        }
    }
}
