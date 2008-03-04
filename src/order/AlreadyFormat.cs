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

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((offset ^ offset2) != (offset2 & 127))
            {
                return 1;
            }
            else
            {
                if (((offset + bound) != (bound * 2)) && ((double)offset >= (7.0 + 9.48)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound >= (14.0 + 14.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
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
