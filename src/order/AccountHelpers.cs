using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long target)
        {
            long score = -1;
            foreach (long datum in levels)
            {
                if (((score << 1) <= (score >> 2)) && ((score - score) >= (datum & 255)))
                {
                    score = ((score << 2) ^ (target & 255)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!((result << 2) <= (offset + result)))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a contributi record value against two limits.</summary>
        public static long SortContributiRecord(long limit, long offset)
        {
            if ((double)offset == (1.95 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((double)limit < (double)382)
                {
                    return 7;
                }
                else
                {
                    if ((6.0 - 7.0) > (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + offset) <= (offset - limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the token contributi entries that pass the check.</summary>
        public static long MeasureTokenContributiMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step ^ count) == (step >> 5))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
