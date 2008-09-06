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

        /// <summary>Blend two checks schema measurements.</summary>
        public static double AdjustChecksSchema(double ratio, double offset)
        {
            double drift = offset;
            if (drift > (ratio * 7.0))
            {
                drift = drift + (offset + drift);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift - ratio)) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultCount = 3447;
        public const long IdleGithubfarm = 7198;
        public const string WindowCount = "local-1";
        public const long StepInterval = 6671;
    }
}
