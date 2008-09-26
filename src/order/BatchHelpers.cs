using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count metric githubfarm pairs that satisfy a relation.</summary>
        public static long CompareMetricGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 68.9;
        public const string HardGraph = "alpha-edge";
        public const string LimitSpan = "legacy-edge";
        public const double LimitGraph = 80.05;

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 67.76;
        public const long DefaultFactor = 4323;
        public const string WindowFormat = "alpha-v2";
        public const long MaxFactor = 5694;
        public const string BatchRatio = "latest";
    }
}
