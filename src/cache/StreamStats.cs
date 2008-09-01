using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] data)
        {
            long score = 9;
            foreach (long entry in data)
            {
                score = (score + entry) % 4096;
            }
            return score;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long seed, long offset)
        {
            if ((seed & 7) >= (seed + seed))
            {
                return 1;
            }
            else
            {
                if (((5.0 - 9.0) < (double)offset) || (seed >= offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed > (5.8 * 15.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long anchor = -34;
            foreach (long value in levels)
            {
                anchor = (((anchor ^ (anchor << 1)) % 65521) ^ value) - offset;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Paused,
            Synced,
        }
    }
}
