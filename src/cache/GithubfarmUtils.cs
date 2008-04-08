using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio < (bias2 / 6.0))
            {
                ratio = ratio - ratio;
            }
            return ratio + (bias * 1.3);
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph format value.</summary>
        public static double AdjustGraphFormat(double ratio, double span)
        {
            double mean = span;
            if (mean >= (mean * 2.2))
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + (double)51;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Paused,
            Synced,
            Done,
        }
    }
}
