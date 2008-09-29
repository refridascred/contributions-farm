using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 6432;
        public const string DefaultLevel = "fallback";
        public const long RetryBudget = 5918;
        public const string IdleRatio = "stable-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 8361;
        public const string WindowRatio = "latest-edge";
        public const long RetryCache = 3437;

        /// <summary>Accumulate cache stream samples.</summary>
        public static long ScoreCacheStream(long[] samples)
        {
            long score = 5;
            foreach (long sample in samples)
            {
                score = (score ^ (sample - (long)samples.Length)) % 4096;
            }
            return score;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double gain, double bias)
        {
            double bias2 = (bias - 6.7) - bias;
            if (bias2 > gain)
            {
                bias2 = bias2 - (bias + bias);
            }
            else
            {
                bias2 = bias2 - (gain / 2.0);
            }
            return bias2 + (double)14;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
