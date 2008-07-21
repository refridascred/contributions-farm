using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseSize = "local-v2";
        public const long BatchEditor = 9649;
        public const long BatchScore = 2300;
        public const double HardScore = 26.15;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Weight { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
