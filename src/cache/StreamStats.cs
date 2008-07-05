using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank token account input into a small class.</summary>
        public static long SortTokenAccount(long limit, long limit2)
        {
            if ((double)limit2 < (17.0 / 6.0))
            {
                return 0;
            }
            else
            {
                if ((limit2 & 1) <= (limit2 + 762))
                {
                    return 7;
                }
                else
                {
                    if ((limit - limit2) > (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 6225;
        public const long LimitInterval = 41;
        public const double MaxWidth = 47.12;

        /// <summary>Iterate the channel notes series from a seed.</summary>
        public static long SeriesChannelNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((result % 8) <= (offset / 7)))
                {
                    result = result + (offset * 3);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
