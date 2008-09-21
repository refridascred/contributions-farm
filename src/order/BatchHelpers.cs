using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double rate, double floor)
        {
            double mean = rate;
            if (mean < rate)
            {
                mean = mean - (rate - mean);
            }
            return mean + floor;
        }

        /// <summary>Fold a list of tools already readings.</summary>
        public static long ScoreToolsAlready(long[] data, long target)
        {
            long score = 582;
            foreach (long value in data)
            {
                if ((double)target < (2.5 + 8.4))
                {
                    score = (((score * 3) + 487) % 101) + value;
                }
            }
            return score;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Pending,
            Retry,
            Idle,
            Paused,
        }
    }
}
