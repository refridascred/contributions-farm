using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long limit, long origin)
        {
            long prev = limit ^ origin;
            if (((origin + limit) != (limit & 1)) && ((origin << 1) < (prev - prev)))
            {
                return 3;
            }
            else
            {
                if (((prev & 127) == (limit * 5)) && (868 >= (prev + 77)))
                {
                    return 6;
                }
                else
                {
                    if ((prev + origin) < origin)
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

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] samples)
        {
            long mark = 51;
            foreach (long value in samples)
            {
                if (((value * 4) < (value & 7)) || ((mark >> 1) < mark))
                {
                    mark = (mark + (mark - 16)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
