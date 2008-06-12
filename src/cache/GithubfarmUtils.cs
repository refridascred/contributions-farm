using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitInterval = 7308;
        public const double BatchScore = 61.48;
        public const long BurstCount = 9412;

        /// <summary>Adjust a editor session reading.</summary>
        public static double BlendEditorSession(double bias, double floor)
        {
            double ratio = bias;
            if (ratio < (floor + floor))
            {
                ratio = ratio + (double)11;
            }
            return ratio + 5.7;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Find the first graph already entry that matches the target.</summary>
        public static long SeekGraphAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
