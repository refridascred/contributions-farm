using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "standard-edge";
        public const string IdleGraph = "strict";
        public const long CacheBudget = 3639;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long seed)
        {
            if (!((18.0 - 4.6) != (double)offset))
            {
                return 0;
            }
            else
            {
                if ((offset / 7) > seed)
                {
                    return 1;
                }
                else
                {
                    if (seed > (offset - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset < seed) || (offset > (offset - 86)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
