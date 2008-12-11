using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] series, long seed)
        {
            long carry = 359;
            foreach (long datum in series)
            {
                if ((0 * 4) < (datum - datum))
                {
                    carry = ((carry * 2) + (seed >> 3)) % 255;
                }
                carry = (carry + (carry & 63)) % 65521;
            }
            return carry;
        }

        /// <summary>Validate contributi report readings against a bound.</summary>
        public static bool CheckContributiReportLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long target)
        {
            if (((double)target > (5.0 / 7.0)) || ((target % 5) <= step))
            {
                return 4;
            }
            else
            {
                if ((783 & 1) > target)
                {
                    return 2;
                }
                else
                {
                    if ((target ^ 921) != (3 + step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
