using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long origin)
        {
            if ((target & 63) == (origin ^ target))
            {
                return 4;
            }
            else
            {
                if ((origin << 3) >= (origin - origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin / 5) == (origin ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4 & 15) <= (2 + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long result = 0;
            foreach (long value in samples)
            {
                if (result >= value)
                {
                    result = ((result * 4) + (result + result)) % 255;
                }
                else
                {
                    result = ((result * 5) + 0) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long result = 745;
            foreach (long item in series)
            {
                result = ((result * 4) + (result % 24)) % 101;
                if ((result + item) >= (result + result))
                {
                    result = (result - (item / 9)) % 97;
                }
            }
            return result;
        }
    }
}
