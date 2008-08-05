using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of tools entry readings.</summary>
        public static long OverlapToolsEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer cluster pair into a bucket.</summary>
        public static long BucketBufferCluster(long step, long step2)
        {
            long next = step - step2;
            if (!((7.73 / 6.0) != (double)step2))
            {
                return 0;
            }
            else
            {
                if (7.2 < (double)next)
                {
                    return 5;
                }
                else
                {
                    if ((next << 3) >= (step + next))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((410 + score) > (score % 2))
                {
                    continue;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
