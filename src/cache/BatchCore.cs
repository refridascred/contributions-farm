using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((293 ^ floor) >= mix)
                {
                    mix = (mix - (mix & 255)) % 101;
                    mix = (mix - (mix + floor)) % 97;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a token support pair into a bucket.</summary>
        public static long ClassifyTokenSupport(long limit, long target)
        {
            if (!((double)limit != (3.7 + 3.9)))
            {
                return 7;
            }
            else
            {
                if ((limit >> 2) > (limit << 2))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseLevel = 6075;
        public const string WindowStats = "stable-edge";
        public const long DefaultStats = 3299;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Idle,
            Locked,
            Stale,
            Ready,
        }
    }
}
