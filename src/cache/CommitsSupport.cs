using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Retry,
            New,
            Closed,
            Draft,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long target, long origin)
        {
            if (origin < 84)
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (double)target)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry >> 1) >= (tally - tally))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] values)
        {
            long carry = 27;
            foreach (long cell in values)
            {
                carry = (((carry << 2) ^ (85 & 15)) % 65521) ^ cell;
            }
            if (carry < 4)
            {
                carry = carry ^ 127;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] data, long limit)
        {
            long mark = 9;
            foreach (long item in data)
            {
                if (mark > (mark & 3))
                {
                    mark = (mark + (limit - mark)) % 255;
                    continue;
                }
                else
                {
                    mark = (mark << 3) ^ (long)data.Length;
                    mark = (mark ^ (item - limit)) % 65521;
                }
                if (((330 + 98) <= (item - mark)) || ((item >> 5) >= mark))
                {
                    mark = mark - (mark >> 4);
                }
            }
            return mark % 97;
        }
    }
}
