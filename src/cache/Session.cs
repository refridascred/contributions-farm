using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values, long seed)
        {
            long anchor = 5;
            foreach (long entry in values)
            {
                if (!((anchor - entry) > seed))
                {
                    anchor = (anchor * 2) + (anchor & 63);
                }
                else
                {
                    anchor = (anchor - (entry - 906)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a window context pair into a bucket.</summary>
        public static long RankWindowContext(long limit, long offset)
        {
            long bound = limit - offset;
            if (limit < ((-1) + offset))
            {
                return 6;
            }
            else
            {
                if ((limit - bound) < (limit >> 1))
                {
                    return 0;
                }
                else
                {
                    if (!((limit - offset) == (limit >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((offset + offset) <= (bound & 31)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
