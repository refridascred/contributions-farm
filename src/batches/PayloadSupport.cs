using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a order metrics pair into a bucket.</summary>
        public static long BucketOrderMetrics(long offset, long step)
        {
            long slot = offset ^ step;
            if ((slot + slot) == (slot + offset))
            {
                return 6;
            }
            else
            {
                if (step <= (7 % 100))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!(seed <= (seed - (long)i)))
                {
                    score = ((score << 3) ^ ((long)i + seed)) % 65521;
                    score = (score ^ score) % 4096;
                }
                if ((seed + seed) <= seed)
                {
                    score = score ^ (score + score);
                }
                score = (score + (score - 66)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((6.85 * 6.7) > (double)anchor)
                {
                    anchor = (anchor - (limit % 7)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
