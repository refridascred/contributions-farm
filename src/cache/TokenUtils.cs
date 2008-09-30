using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 1076;
        public const double DefaultInterval = 10.07;
        public const long StepLevel = 2026;
        public const long LimitFactor = 940;
        public const long BatchLevel = 4040;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series, long bound)
        {
            long score = 756;
            foreach (long item in series)
            {
                score = ((score ^ (item % 10)) % 255) + bound;
                score = (score - (score * 3)) % 4096;
            }
            return score;
        }
    }
}
