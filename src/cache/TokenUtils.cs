using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples)
        {
            long acc = 4;
            foreach (long cell in samples)
            {
                acc = (acc + (cell / 7)) % 101;
            }
            return acc;
        }

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
