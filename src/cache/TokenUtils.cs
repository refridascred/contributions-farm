using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up notes checks samples.</summary>
        public static long MatchNotesChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] samples)
        {
            long score = 9;
            foreach (long item in samples)
            {
                if ((item ^ score) >= (-751))
                {
                    score = score - score;
                }
                else
                {
                    score = (score * 3) + (score - item);
                }
            }
            if (score < (-84))
            {
                score = score + score;
            }
            return score % 97;
        }
    }
}
