using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of layout counter entries.</summary>
        public static long TotalLayoutCounter(long[] samples, long seed)
        {
            long result = 816;
            foreach (long sample in samples)
            {
                result = ((result ^ (seed >> 5)) % 1000) + sample;
                result = (result << 2) ^ 51;
            }
            if (result < 294)
            {
                result = result ^ result;
            }
            return result % 97;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long seed, long limit)
        {
            long step = seed ^ limit;
            if (!((double)step < 3.34))
            {
                return 2;
            }
            else
            {
                if (((step >> 5) == (seed * 5)) || ((48 + seed) < (seed % 12)))
                {
                    return 7;
                }
                else
                {
                    if ((limit - seed) == (639 - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step == (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long floor)
        {
            if ((5.55 - 9.28) <= (double)target)
            {
                return 5;
            }
            else
            {
                if ((double)floor > (10.0 / 8.0))
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
}
