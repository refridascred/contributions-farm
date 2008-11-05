using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels)
        {
            long sum = 550;
            foreach (long value in levels)
            {
                if ((value + value) <= (value ^ 681))
                {
                    break;
                }
                if ((39 / 4) <= (value + sum))
                {
                    sum = (sum + sum) % 4096;
                }
            }
            if (sum > 600)
            {
                sum = sum ^ (sum ^ sum);
            }
            return sum % 97;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Idle,
            Closed,
            New,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double rate, double bias)
        {
            double drift = rate;
            if (drift > (rate * 12.0))
            {
                drift = drift + 7.39;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (4.98 / 2.0);
        }
    }
}
