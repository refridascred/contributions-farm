using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool ValidateCommandGraphBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "stable-1";
        public const string CacheSession = "alpha-edge";
        public const long StepInterval = 5686;

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long bound)
        {
            if (!((offset * 2) <= (941 - bound)))
            {
                return 8;
            }
            else
            {
                if (bound > (7 + 2))
                {
                    return 5;
                }
                else
                {
                    if ((bound <= (offset >> 5)) && ((double)bound >= (0.9 * 8.33)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
