using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Synced,
            New,
            Queued,
        }

        /// <summary>Grade a queue stream value against two limits.</summary>
        public static long BucketQueueStream(long target, long seed)
        {
            long step = target ^ seed;
            if (target <= (target % 8))
            {
                return 2;
            }
            else
            {
                if (step <= (5 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((target + seed) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + seed) <= (target ^ 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings, long seed)
        {
            long anchor = 64;
            foreach (long cell in readings)
            {
                if (((double)cell < 13.0) || ((cell - cell) <= (368 / 3)))
                {
                    anchor = ((anchor + (975 << 2)) % 97) - seed;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (cell & 255)) % 65521;
                }
            }
            return anchor;
        }
    }
}
