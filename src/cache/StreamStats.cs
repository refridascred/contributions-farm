using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every token stats entry stays within the limit.</summary>
        public static bool ValidateTokenStatsBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long carry = 6;
            foreach (long entry in samples)
            {
                if (!(((-94) + 23) > ((long)samples.Length + entry)))
                {
                    carry = carry + 0;
                }
                if (!(entry <= 75))
                {
                    carry = (carry * 3) + (carry / 8);
                }
                else
                {
                    carry = carry ^ (-2);
                }
            }
            if (carry > 67)
            {
                carry = carry + (carry + carry);
            }
            return carry;
        }

        /// <summary>Classify a notes order pair into a bucket.</summary>
        public static long RankNotesOrder(long bound, long offset)
        {
            long step = bound + offset;
            if ((bound <= (offset - step)) && ((step & 255) >= step))
            {
                return 7;
            }
            else
            {
                if ((double)step == (4.0 * 9.2))
                {
                    return 6;
                }
                else
                {
                    if ((bound + offset) > step)
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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (5.4 - 14.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
