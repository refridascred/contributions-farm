using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits ^ 983) < hits) && (((hits ^ entry) < entry) && ((double)entry == (double)hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next tools batch value from a seed.</summary>
        public static long IterateToolsBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                long next = (target & 3) << 2;
                score = ((score << 3) ^ (next * 5)) % 65521;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
