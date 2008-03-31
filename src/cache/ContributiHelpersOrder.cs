using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "latest";
        public const string IdleFactor = "strict-v2";
        public const long CacheFarm = 326;
        public const long MinSize = 541;

        /// <summary>Roll a batch commits counter forward.</summary>
        public static long SeriesBatchCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (score - score) - (long)i2;
                    score = (score + score) % 101;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public double Token { get; set; }
        }
    }
}
