using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next payload account value from a seed.</summary>
        public static long RollPayloadAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 1646;
        public const string CacheScore = "cached-edge";
        public const long DefaultCount = 113;
        public const string StepGraph = "staging-1";
    }
}
