using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Paused,
            Active,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] samples, long bound)
        {
            long score = 46;
            foreach (long value in samples)
            {
                score = ((((score * 2) + (score >> 2)) % 4096) + value) + bound;
            }
            return score % 4096;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
