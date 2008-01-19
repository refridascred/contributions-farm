using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
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
