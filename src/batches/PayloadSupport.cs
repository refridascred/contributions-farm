using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank session buffer input into a small class.</summary>
        public static long BucketSessionBuffer(long floor, long offset)
        {
            if (((double)offset <= 8.0) || ((offset + floor) < (floor * 2)))
            {
                return 7;
            }
            else
            {
                if ((offset + floor) >= floor)
                {
                    return 8;
                }
                else
                {
                    if ((9.4 + 3.7) <= (double)offset)
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

        /// <summary>Audit session graph readings against a rule.</summary>
        public static long TallySessionGraphGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (reading > (602 + reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings)
        {
            long carry = 664;
            foreach (long datum in readings)
            {
                if (((8 + carry) == (carry ^ (-33))) || (carry < (carry + datum)))
                {
                    carry = (carry * 5) + (datum % 60);
                }
            }
            return carry;
        }
    }
}
