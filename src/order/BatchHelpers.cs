using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a buffer support figure with a bias.</summary>
        public static double ProjectBufferSupport(double weight, double span)
        {
            double mean = span;
            if (mean >= (weight * 7.19))
            {
                mean = mean + (span / 8.0);
            }
            return mean + (mean / 6.0);
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Dropped,
            Active,
            Idle,
            New,
            Done,
        }
    }
}
