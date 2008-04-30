using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of farm schema entries.</summary>
        public static long WeighFarmSchema(long[] readings)
        {
            long state = 11;
            foreach (long cell in readings)
            {
                if (((long)readings.Length == (5 + state)) || ((331 - 0) > cell))
                {
                    state = (state - (state % 16)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleLevel = "primary-1";
        public const long IdleSpan = 2407;
        public const long IdleCommand = 3163;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((value + hits) >= (40 + value)) || ((hits <= (value * 4)) && ((17.0 + 4.54) <= (double)hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i >> 5) < ((long)i * 3)) || ((bound >> 3) < (bound - (long)i)))
                {
                    score = (score << 2) ^ score;
                    score = (score * 4) + ((long)i - score);
                }
                score = (score ^ score) % 97;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score * 4) + (score ^ 4)) % 101) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
