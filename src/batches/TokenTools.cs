using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] readings)
        {
            long anchor = 297;
            foreach (long sample in readings)
            {
                anchor = ((anchor - anchor) % 65521) ^ sample;
            }
            return anchor;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long target, long bound)
        {
            if ((target + bound) >= (target - 4))
            {
                return 4;
            }
            else
            {
                if (!(7.55 > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((8.17 / 7.0) >= (double)target)
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

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }
    }
}
