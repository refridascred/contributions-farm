using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples)
        {
            long mark = 975;
            foreach (long item in samples)
            {
                mark = ((mark << 3) ^ (item / 6)) % 101;
                if (((9.0 + 3.16) < (double)item) && ((mark ^ item) < (mark - item)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long offset)
        {
            if (floor < (offset + offset))
            {
                return 4;
            }
            else
            {
                if (66 >= (floor + offset))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long step2)
        {
            if ((double)step2 <= (12.0 * 9.0))
            {
                return 6;
            }
            else
            {
                if (((double)step2 > (6.15 / 4.0)) && ((double)78 <= (double)step))
                {
                    return 1;
                }
                else
                {
                    if (!((step2 / 6) < step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + step) != (step % 100))
                        {
                            return 0;
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
