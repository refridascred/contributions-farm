using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the tools batch entries that pass the check.</summary>
        public static long CountToolsBatchHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + matches) > sample)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Idle,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Queued,
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Derive the next commits batches value from a seed.</summary>
        public static long StepCommitsBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = (score + (origin + score)) % 4096;
                score = (score << 2) ^ (score / 2);
                score = (score << 2) ^ score;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
