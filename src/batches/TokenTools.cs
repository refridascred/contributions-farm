using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long seed, long step)
        {
            long edge = seed + step;
            if ((double)seed != (2.0 / 7.0))
            {
                return 7;
            }
            else
            {
                if (!((double)seed <= 0.2))
                {
                    return 8;
                }
                else
                {
                    if ((step / 2) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((2 ^ 6) > (step << 1)) && ((seed ^ edge) > (seed >> 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 53.88;
        public const long BaseFormat = 4477;
        public const string MaxFormat = "standard";
        public const string RetryFactor = "open";
        public const long MinCount = 8747;

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "open";
        public const double DefaultTimeout = 72.62;
        public const long MinPayload = 6224;
    }
}
