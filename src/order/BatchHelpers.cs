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

        /// <summary>Match up token tools samples.</summary>
        public static long PairTokenToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
