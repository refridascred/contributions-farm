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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long limit, long offset)
        {
            if (8.3 <= (double)limit)
            {
                return 8;
            }
            else
            {
                if ((1.0 * 4.49) > (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((double)offset != (17.0 * 2.7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((limit / 8) >= 75) || ((limit - limit) == (limit + 42)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
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
