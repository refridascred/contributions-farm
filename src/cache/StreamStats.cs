using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] data, long limit)
        {
            long score = -345;
            foreach (long sample in data)
            {
                if (((sample >> 2) >= (score << 1)) && ((3 & 127) != (sample - sample)))
                {
                    score = (score ^ (score * 2)) % 4096;
                }
                else
                {
                    score = (score ^ (score - 1)) % 1000;
                }
                if ((limit << 3) == (sample - score))
                {
                    break;
                }
            }
            if (score < 8)
            {
                score = (score - (limit & 15)) % 4096;
            }
            return score;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long limit, long origin)
        {
            long slot = limit + origin;
            if (origin >= 40)
            {
                return 7;
            }
            else
            {
                if (slot > (origin - limit))
                {
                    return 1;
                }
                else
                {
                    if (((4.76 + 8.84) == (double)slot) && (origin > limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit <= (limit % 12))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of token metric readings.</summary>
        public static long DigestTokenMetric(long[] values, long offset)
        {
            long state = 759;
            foreach (long value in values)
            {
                state = ((state - (value - 687)) % 1000) - offset;
            }
            return state;
        }
    }
}
