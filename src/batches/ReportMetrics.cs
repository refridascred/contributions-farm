using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 3555;
        public const long StepCount = 1339;
        public const string MinWindow = "fallback-v2";

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long limit, long seed)
        {
            if (((limit << 1) != (seed * 5)) && ((seed / 8) > (seed & 3)))
            {
                return 8;
            }
            else
            {
                if (((7.47 - 5.87) < (double)seed) || ((double)limit >= (19.0 + 2.92)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed >= (7.0 + 6.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 97) < (seed + 524))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long target, long offset)
        {
            if (((target + offset) != (20 - offset)) || ((7.0 * 4.0) < (double)target))
            {
                return 0;
            }
            else
            {
                if ((1.71 * 6.51) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 2) == (offset - 932))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target * 5) == (target >> 4))
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
        }
    }
}
