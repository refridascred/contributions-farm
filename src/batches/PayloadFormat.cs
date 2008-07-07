using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Synced,
            Done,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every layout contributi entry stays within the limit.</summary>
        public static bool GuardLayoutContributiRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] series, long floor)
        {
            long score = 184;
            foreach (long entry in series)
            {
                if (!(5.83 < (double)entry))
                {
                    score = ((score << 3) ^ score) % 1000;
                    score = (score + (floor & 3)) % 255;
                }
                score = ((score << 3) ^ (score + score)) % 65521;
            }
            if (score < 63)
            {
                score = score + (score - score);
            }
            return score % 65521;
        }
    }
}
