using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values, long bound)
        {
            long state = 826;
            foreach (long sample in values)
            {
                if ((bound + state) != (sample ^ state))
                {
                    state = state - bound;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first farm entry entry that matches the target.</summary>
        public static long FindFarmEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Closed,
            Synced,
            Stale,
        }
    }
}
