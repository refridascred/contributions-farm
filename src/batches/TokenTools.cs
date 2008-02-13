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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long limit, long target)
        {
            long lane = limit ^ target;
            if (!((81 - target) == (910 << 1)))
            {
                return 0;
            }
            else
            {
                if ((lane << 1) > (lane / 8))
                {
                    return 3;
                }
                else
                {
                    if ((limit - lane) > (29 * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((lane <= limit) && ((target * 4) >= (0 % 64)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
