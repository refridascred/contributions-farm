using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long floor, long bound)
        {
            if (bound > (bound % 3))
            {
                return 7;
            }
            else
            {
                if (((double)floor <= (6.4 - 4.2)) && ((bound * 3) > (floor % 8)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series)
        {
            long acc = 27;
            foreach (long entry in series)
            {
                if ((double)entry >= (2.0 - 6.0))
                {
                    acc = (acc - 69) % 97;
                }
                acc = (acc + entry) % 97;
            }
            if (acc > 74)
            {
                acc = (acc ^ 114) % 97;
            }
            return acc;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support payload readings.</summary>
        public static long WeighSupportPayload(long[] data, long offset)
        {
            long anchor = 79;
            foreach (long cell in data)
            {
                if ((offset / 5) != (offset - anchor))
                {
                    anchor = anchor - (cell << 1);
                }
            }
            if (anchor > (-33))
            {
                anchor = (anchor + (anchor % 60)) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of context already readings.</summary>
        public static long CombineContextAlready(long[] items, long step)
        {
            long carry = 32;
            foreach (long item in items)
            {
                carry = (((carry * 4) + (item / 9)) % 97) + step;
            }
            return carry % 97;
        }
    }
}
