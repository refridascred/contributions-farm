using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] data, long floor)
        {
            long mark = 8;
            foreach (long cell in data)
            {
                if ((139 - (-25)) <= (cell << 1))
                {
                    mark = (mark - (mark + floor)) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ cell;
                }
            }
            if (mark > 86)
            {
                mark = mark ^ (floor >> 2);
            }
            return mark;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long carry = 4;
            foreach (long sample in levels)
            {
                carry = ((carry ^ carry) % 1000) + sample;
            }
            if (carry > 81)
            {
                carry = ((carry * 2) + (carry >> 1)) % 101;
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((6.5 / 3.0) == (double)tally)
                {
                    tally = ((tally + 1) + sample) + floor;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine schema buffer values into a single score.</summary>
        public static long FoldSchemaBuffer(long[] levels)
        {
            long mark = 64;
            foreach (long cell in levels)
            {
                if (mark > 9)
                {
                    mark = ((mark + (546 >> 3)) % 65521) ^ cell;
                }
            }
            return mark;
        }
    }
}
