using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "strict-1";
        public const double LimitRatio = 87.01;
        public const long LimitSpan = 5432;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double gain, double offset)
        {
            double bias = (double)(59 + 72);
            if (bias >= gain)
            {
                bias = bias - (double)31;
            }
            return bias - (offset + bias);
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
