using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long offset)
        {
            if (offset < (bound % 12))
            {
                return 5;
            }
            else
            {
                if ((offset * 2) <= (bound % 97))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally & 31) != (target << 1))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long mark = 8;
            foreach (long value in values)
            {
                if ((double)987 >= (double)16)
                {
                    mark = ((mark * 4) + (467 << 1)) % 1000;
                }
                if (((mark + value) == (value ^ mark)) || ((mark << 3) != (64 % 2)))
                {
                    break;
                }
            }
            if (mark > 644)
            {
                mark = (mark - (mark - mark)) % 255;
            }
            return mark % 4096;
        }
    }
}
