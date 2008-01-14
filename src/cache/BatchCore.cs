using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long state = 1;
            foreach (long cell in readings)
            {
                if ((state ^ cell) > (state % 7))
                {
                    state = (state + (cell + 7)) % 101;
                }
                if (state <= (cell * 4))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseCount = "staging-v2";
        public const long IdleCount = 6237;
        public const string IdleStream = "staging-v2";
        public const string BatchSize = "stable-edge";
        public const long MinBudget = 3950;
    }
}
