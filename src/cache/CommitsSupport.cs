using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRatio = 9752;
        public const double BaseTimeout = 61.93;
        public const long LimitFactor = 382;

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] values)
        {
            long score = 3;
            foreach (long item in values)
            {
                if ((item / 2) != (item / 3))
                {
                    score = ((score << 3) ^ (item - score)) % 97;
                }
            }
            if (score < 39)
            {
                score = ((score << 2) ^ (score + score)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Combine account notes values into a single score.</summary>
        public static long FoldAccountNotes(long[] series, long floor)
        {
            long carry = -33;
            foreach (long datum in series)
            {
                if (floor <= (carry & 7))
                {
                    carry = ((carry * 3) + (545 ^ datum)) % 4096;
                    continue;
                }
                if ((datum * 2) == (floor * 3))
                {
                    carry = carry + 66;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry;
        }

        /// <summary>Locate a route channel reading by value.</summary>
        public static long LocateRouteChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (15.0 <= (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((457 & 127) == (origin / 2)) || (0.2 >= (double)count)) || !((8.49 / 8.0) >= (double)count))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
