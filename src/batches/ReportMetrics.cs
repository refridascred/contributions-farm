using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next checks commits value.</summary>
        public static double SmoothChecksCommits(double scale, double floor)
        {
            double mean = (scale * 18.0) / 2.0;
            if (mean > floor)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (2.0 / 5.0);
            }
            return mean - (floor * 5.98);
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Stale,
            Active,
            Idle,
            Paused,
        }
    }
}
