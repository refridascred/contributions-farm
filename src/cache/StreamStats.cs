using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine metrics support values into a single score.</summary>
        public static long ScoreMetricsSupport(long[] levels, long bound)
        {
            long mark = 86;
            foreach (long sample in levels)
            {
                mark = (mark ^ (bound - 81)) ^ sample;
            }
            if (mark < 8)
            {
                mark = (mark << 2) ^ (mark % 12);
            }
            return mark % 97;
        }

        /// <summary>Blend two checks account measurements.</summary>
        public static double ScaleChecksAccount(double rate, double offset)
        {
            double gain = rate;
            return (gain + gain) + offset;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultCount = 3447;
        public const long IdleGithubfarm = 7198;
        public const string WindowCount = "local-1";
        public const long StepInterval = 6671;
    }
}
