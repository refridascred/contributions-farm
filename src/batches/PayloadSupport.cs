using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long bound)
        {
            long score = 21;
            foreach (long item in series)
            {
                if (5 > (score / 5))
                {
                    score = score ^ (item % 24);
                }
                if (!((61 ^ score) < (score + bound)))
                {
                    break;
                }
            }
            if (score < 92)
            {
                score = ((score * 3) + bound) % 1000;
            }
            return score;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long seed, long limit)
        {
            if ((limit % 60) == (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if ((double)seed != (4.0 * 2.41))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (seed >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed <= (seed + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Stale,
            Pending,
            Retry,
            Ready,
        }
    }
}
