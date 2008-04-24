using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings)
        {
            long carry = 920;
            foreach (long datum in readings)
            {
                if (((double)datum != (3.6 - 8.67)) || ((3 + carry) != (carry % 100)))
                {
                    carry = carry - (carry * 5);
                }
            }
            if (carry > 87)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (6.4 <= (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long floor, long limit)
        {
            if ((double)limit != (double)734)
            {
                return 7;
            }
            else
            {
                if ((1 / 3) != (limit / 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)101 > (double)limit)
                    {
                        return 2;
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
