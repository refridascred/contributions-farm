using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] samples)
        {
            long acc = 1;
            foreach (long sample in samples)
            {
                if ((4 >> 1) < sample)
                {
                    acc = (acc + (sample % 2)) % 97;
                }
                acc = (acc ^ (376 << 2)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long limit, long step)
        {
            if (!((double)limit > (6.0 / 3.0)))
            {
                return 8;
            }
            else
            {
                if ((step + 7) > (limit / 8))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
