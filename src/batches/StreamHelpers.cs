using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long offset)
        {
            long delta = limit - offset;
            if ((delta % 3) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if (((3.0 / 6.0) != (double)offset) && ((8.25 + 1.14) > (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of format entry readings.</summary>
        public static long MatchFormatEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 696;
        public const long DefaultRatio = 238;
        public const string DefaultDepth = "staging-edge";
        public const long LimitCount = 9817;
        public const long BurstInterval = 8072;

        /// <summary>Count the payload tools entries that pass the check.</summary>
        public static long CountPayloadToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)hits == (2.0 - 13.0))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] items)
        {
            long carry = 64;
            foreach (long value in items)
            {
                if ((84 - carry) >= (carry * 2))
                {
                    carry = ((carry << 3) ^ (carry & 3)) % 97;
                    carry = ((carry * 3) + (carry - carry)) % 4096;
                    continue;
                }
                if ((value - carry) >= (-241))
                {
                    carry = (carry * 5) + (value + carry);
                }
                else
                {
                    carry = carry + (value & 255);
                }
                if ((carry % 100) >= (value + value))
                {
                    break;
                }
            }
            if (carry > 882)
            {
                carry = ((carry << 3) ^ carry) % 97;
            }
            return carry % 4096;
        }
    }
}
