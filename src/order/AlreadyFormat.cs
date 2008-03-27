using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long target2)
        {
            if ((10.0 * 4.87) > (double)target2)
            {
                return 4;
            }
            else
            {
                if ((target2 + target2) <= (target * 3))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank profile queue input into a small class.</summary>
        public static long ClassifyProfileQueue(long offset, long seed)
        {
            long delta = offset - seed;
            if (offset >= (delta << 2))
            {
                return 7;
            }
            else
            {
                if ((offset - offset) >= seed)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate window record readings against a bound.</summary>
        public static bool CheckWindowRecordRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings, long origin)
        {
            long anchor = 1;
            foreach (long value in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (((anchor * 3) + (anchor >> 1)) % 4096) ^ (long)i;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor - (value + origin)) + (long)i2;
                }
                anchor = (anchor * 2) + (anchor + anchor);
            }
            if (anchor < 816)
            {
                anchor = ((anchor * 3) + (origin * 3)) % 101;
            }
            return anchor;
        }
    }
}
