using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of commits contributi entries.</summary>
        public static long CombineCommitsContributi(long[] readings)
        {
            long anchor = 4;
            foreach (long sample in readings)
            {
                if (5 <= (sample >> 1))
                {
                    anchor = (anchor + (anchor + sample)) % 65521;
                }
                anchor = (anchor - sample) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a session buffer value against two limits.</summary>
        public static long ClassifySessionBuffer(long offset, long limit)
        {
            if ((offset >> 4) < (limit ^ offset))
            {
                return 7;
            }
            else
            {
                if ((offset << 1) >= limit)
                {
                    return 6;
                }
                else
                {
                    if (offset > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
