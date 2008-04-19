using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long target, long target2)
        {
            if ((target - target) > (2 >> 5))
            {
                return 6;
            }
            else
            {
                if ((target2 * 2) <= (78 & 63))
                {
                    return 2;
                }
                else
                {
                    if ((12.0 - 4.67) < (double)target2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (target2 <= (target * 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Token { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
