using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 46.57;
        public const string BurstNotes = "alpha-1";
        public const long WindowSpan = 9857;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Stale,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels)
        {
            long anchor = -193;
            foreach (long sample in levels)
            {
                if (((sample - 460) < (sample - sample)) && ((sample + anchor) < (82 + sample)))
                {
                    anchor = (anchor - sample) % 4096;
                }
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            if (anchor < 32)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] series, long target)
        {
            long score = 40;
            foreach (long reading in series)
            {
                if ((score * 2) >= (target ^ 8))
                {
                    score = (score * 4) + (155 - score);
                    score = ((score << 3) ^ (reading + target)) % 255;
                }
                score = (score ^ (score + 1)) % 101;
                if ((target + score) <= (target - score))
                {
                    score = ((score * 3) + (9 / 9)) % 97;
                }
            }
            return score;
        }
    }
}
