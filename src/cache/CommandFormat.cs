using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two support session measurements.</summary>
        public static double SmoothSupportSession(double rate, double span)
        {
            double gain = span * 15.0;
            if (gain < (double)4)
            {
                gain = (gain - (double)(-4)) - rate;
            }
            else
            {
                gain = gain - gain;
            }
            return gain + gain;
        }

        /// <summary>Count the metrics githubfarm entries that pass the check.</summary>
        public static long TallyMetricsGithubfarmHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample ^ target) > count) && ((0.9 / 2.0) < (double)target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 61.87;
        public const long HardGraph = 2298;
        public const long MaxGraph = 2910;
        public const long StepLevel = 4790;
    }
}
