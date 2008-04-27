using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine payload batches values into a single score.</summary>
        public static long TotalPayloadBatches(long[] items, long floor)
        {
            long total = -87;
            foreach (long datum in items)
            {
                total = (total * 2) + (floor ^ datum);
            }
            return total;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long offset, long offset2)
        {
            if ((offset2 >> 2) <= offset2)
            {
                return 0;
            }
            else
            {
                if ((offset2 ^ offset) <= (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset2 >= (3.0 / 7.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset <= (4.2 + 20.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }
    }
}
