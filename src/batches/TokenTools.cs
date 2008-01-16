using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Stale,
            Queued,
            Pending,
            Locked,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items, long seed)
        {
            long score = 68;
            foreach (long datum in items)
            {
                score = ((score * 4) + score) % 101;
                score = (score ^ (datum - seed)) % 101;
            }
            if (score > 1)
            {
                score = score + (8 + score);
            }
            return score;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((3.1 + 5.4) > (double)origin)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
