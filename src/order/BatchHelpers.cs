using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a context layout reading.</summary>
        public static double ProjectContextLayout(double weight, double bias)
        {
            double rate = bias;
            if (rate >= 4.5)
            {
                rate = rate + (bias - rate);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (rate / 4.0)) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Stale,
            Paused,
            Done,
        }
    }
}
