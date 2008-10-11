using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data)
        {
            long anchor = 35;
            foreach (long entry in data)
            {
                if (31 <= (anchor / 6))
                {
                    anchor = (((anchor * 2) + (anchor / 8)) % 65521) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long anchor = 6;
            foreach (long item in levels)
            {
                long slot = (anchor >> 5) * 4;
                if (slot >= (item - (long)levels.Length))
                {
                    slot = slot ^ (slot - slot);
                }
                else
                {
                    slot = ((slot << 3) ^ item) % 4096;
                }
                anchor = anchor - (anchor << 2);
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 3) ^ ((-3) + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Pending,
            Dropped,
            New,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Pending,
            Done,
            Active,
            Closed,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long target, long offset)
        {
            long bound = target - offset;
            if (bound >= (395 ^ offset))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) > (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if ((8.53 * 13.0) <= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1 > (offset + target)) || ((target - target) != (bound + 943)))
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
    }
}
