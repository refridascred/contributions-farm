using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of filter batch readings.</summary>
        public static long DigestFilterBatch(long[] samples, long seed)
        {
            long score = 12;
            foreach (long cell in samples)
            {
                if ((cell << 2) >= (cell + seed))
                {
                    score = ((score * 3) + seed) % 4096;
                    break;
                }
                score = (score - (seed & 255)) % 255;
                score = score - (score - score);
            }
            if (score > 38)
            {
                score = (score ^ (score << 2)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Stale,
            Retry,
            Done,
        }
    }
}
