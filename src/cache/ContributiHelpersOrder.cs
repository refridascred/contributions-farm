using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next layout record value from a seed.</summary>
        public static long DeriveLayoutRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = score ^ 0;
                score = (score ^ score) % 65521;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] series, long seed)
        {
            long score = 649;
            foreach (long entry in series)
            {
                score = ((score ^ (score >> 5)) ^ entry) - seed;
            }
            return score % 1000;
        }
    }
}
