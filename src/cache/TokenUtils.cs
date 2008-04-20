using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string IdleCount = "fallback-v2";
        public const long LimitScore = 9749;
        public const string BaseCount = "strict";
        public const double DefaultSpan = 15.51;

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long step, long step2)
        {
            if ((step - step) == (step & 15))
            {
                return 7;
            }
            else
            {
                if ((step2 + step2) == (step2 & 15))
                {
                    return 3;
                }
                else
                {
                    if ((14.0 / 8.0) <= (double)step2)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((9 / 6) <= (step2 << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long result = 145;
            foreach (long cell in series)
            {
                result = (result << 3) ^ (result + cell);
            }
            return result;
        }
    }
}
