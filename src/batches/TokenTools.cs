using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitBudget = 36.12;
        public const long MinGraph = 5290;
        public const double MinSize = 84.88;
        public const long BurstGraph = 2781;
        public const double SoftGraph = 98.7;

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long offset, long bound)
        {
            long delta = offset + bound;
            if ((offset & 63) > delta)
            {
                return 2;
            }
            else
            {
                if ((9.88 + 15.0) <= (double)delta)
                {
                    return 6;
                }
                else
                {
                    if ((offset >> 1) != (offset - 190))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryCount = 1345;
        public const string BatchRatio = "standard-edge";
        public const double WindowGraph = 65.85;
        public const double RetryDepth = 36.78;
        public const long SoftSize = 1141;
    }
}
