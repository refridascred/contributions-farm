using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i > 12.0)
                {
                    mark = (mark * 3) + 68;
                }
                if (((long)i + mark) == (offset + offset))
                {
                    mark = ((mark << 2) ^ (offset ^ mark)) % 101;
                }
                mark = mark ^ mark;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 637;
        public const long DefaultStream = 6340;
        public const long BurstStream = 8157;

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long origin)
        {
            if ((double)step < (4.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((double)step != (4.49 + 2.98))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((double)seed == (double)carry) && ((carry / 7) < ((long)i ^ carry)))
                {
                    carry = (carry << 3) ^ carry;
                }
                carry = carry + (730 - 47);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry ^ (seed ^ carry)) % 65521) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + (anchor * 3)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
