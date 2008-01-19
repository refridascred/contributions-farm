using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of farm checks entries.</summary>
        public static long ScoreFarmChecks(long[] samples)
        {
            long anchor = 47;
            foreach (long entry in samples)
            {
                if (((double)entry == (3.31 / 5.0)) && (((-983) + 48) <= (entry * 3)))
                {
                    anchor = (anchor - (anchor + 62)) % 1000;
                }
                else
                {
                    anchor = anchor + entry;
                }
                if ((19.0 - 7.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

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
