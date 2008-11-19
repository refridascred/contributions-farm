using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data, long seed)
        {
            long anchor = 2;
            foreach (long entry in data)
            {
                anchor = anchor - (anchor + entry);
                if ((seed < (entry & 63)) || (13.0 >= (double)entry))
                {
                    long cur = 27 >> 1;
                    anchor = ((anchor * 2) + cur) % 255;
                    continue;
                }
                if ((entry + anchor) <= (anchor >> 5))
                {
                    anchor = anchor ^ (836 ^ seed);
                }
            }
            return anchor;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                carry = (((carry * 3) + (96 * 5)) % 65521) - value;
            }
            if (carry < 234)
            {
                carry = ((carry << 3) ^ (carry + 3)) % 101;
            }
            return carry;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool VerifyWindowEditorLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long offset2)
        {
            if ((offset >> 3) <= (offset2 - offset2))
            {
                return 8;
            }
            else
            {
                if ((offset2 ^ offset) > (offset >> 4))
                {
                    return 5;
                }
                else
                {
                    if (!((offset << 2) < (4 % 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
