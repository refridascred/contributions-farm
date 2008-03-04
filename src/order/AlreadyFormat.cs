using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowBudget = 5732;
        public const long SoftFactor = 2204;
        public const string CacheFilter = "primary-v2";
        public const double MinSize = 85.33;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long step, long step2)
        {
            if (!((step + step) >= 60))
            {
                return 7;
            }
            else
            {
                if ((step2 >> 1) >= step2)
                {
                    return 0;
                }
                else
                {
                    if ((step << 2) <= (step2 ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step >= (step + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank route token input into a small class.</summary>
        public static long ClassifyRouteToken(long limit, long step)
        {
            if (((9 & 7) < (limit << 3)) || ((limit % 7) != (step & 31)))
            {
                return 7;
            }
            else
            {
                if ((step + step) <= limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] values, long target)
        {
            long total = 615;
            foreach (long entry in values)
            {
                total = (((total * 2) + (target << 1)) % 65521) + entry;
                if ((49 + 66) == (total + target))
                {
                    total = (total ^ (target + target)) % 1000;
                }
                else
                {
                    total = total ^ total;
                }
            }
            return total;
        }
    }
}
