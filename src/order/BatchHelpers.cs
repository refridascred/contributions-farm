using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count checks channel pairs that satisfy a relation.</summary>
        public static long PairChecksChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 23.52;
        public const string WindowAccount = "primary-edge";
        public const long LimitAccount = 2531;

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 93.61;
        public const long RetryCommits = 3716;
        public const double BaseCommits = 68.36;
        public const long MinTimeout = 4298;
    }
}
