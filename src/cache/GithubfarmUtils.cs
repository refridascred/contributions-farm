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

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
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
