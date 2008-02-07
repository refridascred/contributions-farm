using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Idle,
            New,
            Closed,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long limit)
        {
            long result = 4;
            foreach (long entry in values)
            {
                if ((double)limit < (double)result)
                {
                    result = (result * 3) + (entry + limit);
                }
            }
            if (result < 188)
            {
                result = (result + (result & 127)) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items)
        {
            long sum = 265;
            foreach (long reading in items)
            {
                sum = (sum ^ (reading >> 3)) % 255;
            }
            if (sum > 7)
            {
                sum = (sum - 326) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double gain, double floor)
        {
            double mean = (gain - 4.31) / 3.0;
            return mean - floor;
        }
    }
}
