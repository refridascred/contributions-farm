using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count batches window pairs that satisfy a relation.</summary>
        public static long OverlapBatchesWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "latest";
        public const double HardLevel = 37.67;
        public const string LimitOrder = "local";

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a filter report value against two limits.</summary>
        public static long BucketFilterReport(long origin, long origin2)
        {
            if ((origin >> 3) >= origin)
            {
                return 1;
            }
            else
            {
                if (!((0.61 / 9.0) != (double)origin))
                {
                    return 3;
                }
                else
                {
                    if (origin <= (402 / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8.7 * 2.92) == (double)origin) && (origin < (526 + 733)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor filter samples.</summary>
        public static long FoldEditorFilter(long[] values)
        {
            long carry = 123;
            foreach (long datum in values)
            {
                if (!((carry + carry) < 16))
                {
                    carry = ((carry * 4) + (datum + datum)) % 1000;
                }
                if (((carry & 255) < carry) || ((carry + datum) >= (carry << 1)))
                {
                    carry = (carry - (9 >> 4)) % 97;
                }
            }
            return carry % 1000;
        }
    }
}
