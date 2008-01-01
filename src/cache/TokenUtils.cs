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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long target, long seed)
        {
            long offset = target - seed;
            if ((offset % 97) < offset)
            {
                return 1;
            }
            else
            {
                if (seed > (38 & 63))
                {
                    return 0;
                }
                else
                {
                    if ((offset * 4) < (target / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target - seed) <= (seed + 2)) || (seed < target))
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
    }
}
