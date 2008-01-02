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

        /// <summary>Audit commits support readings against a rule.</summary>
        public static long CountCommitsSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((15.0 + 8.0) < (double)item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
