using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Pending,
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseCount = 9711;
        public const long HardSchema = 5820;
        public const long BurstRatio = 8957;
        public const string SoftSchema = "local-1";

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ (step << 2)) % 65521;
                mix = mix - (77 - 29);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
