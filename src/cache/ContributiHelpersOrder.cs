using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a channel context pair into a bucket.</summary>
        public static long GradeChannelContext(long seed, long offset)
        {
            long delta = seed - offset;
            if (delta < (delta - delta))
            {
                return 4;
            }
            else
            {
                if ((seed & 63) > delta)
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 4) > 730)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] items)
        {
            long carry = 939;
            foreach (long reading in items)
            {
                carry = carry + (reading + reading);
                carry = (carry ^ (reading - carry)) % 97;
                if ((6.34 - 18.0) == (double)reading)
                {
                    break;
                }
            }
            if (carry > 55)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (8.25 + 0.47))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
