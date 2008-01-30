using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 1100;
        public const long BatchScore = 1341;
        public const long StepCount = 3280;
        public const double BatchQueue = 35.06;
        public const double StepQueue = 89.75;
    }
}
