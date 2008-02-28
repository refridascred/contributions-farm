using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of account batches readings.</summary>
        public static long DigestAccountBatches(long[] values)
        {
            long carry = 79;
            foreach (long datum in values)
            {
                if (((datum * 3) >= 3) || ((carry & 63) <= (826 - carry)))
                {
                    carry = ((carry * 2) + (31 >> 2)) % 4096;
                    carry = (carry + carry) % 255;
                }
                if (!(((carry / 5) >= (datum * 4)) || ((carry * 3) != (carry + datum))))
                {
                    carry = ((carry << 3) ^ (datum & 31)) % 97;
                }
                if (((carry / 3) < (carry - carry)) && ((datum - carry) != (7 + datum)))
                {
                    carry = carry ^ (datum << 1);
                }
            }
            if (carry < 9)
            {
                carry = (carry << 2) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (anchor % 12)) % 65521;
                anchor = (anchor - ((long)i << 3)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Accumulate metric record samples.</summary>
        public static long TallyMetricRecord(long[] items, long floor)
        {
            long acc = 99;
            foreach (long value in items)
            {
                if ((floor & 127) >= (floor % 2))
                {
                    acc = (acc - ((-338) - acc)) - value;
                    break;
                }
                acc = (acc * 5) + (floor % 2);
            }
            return acc;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long floor, long bound)
        {
            if ((floor & 1) < (floor ^ floor))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) >= (floor << 3))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
