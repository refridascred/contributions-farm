using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long target, long offset)
        {
            long cur = target ^ offset;
            if ((double)52 >= (double)cur)
            {
                return 1;
            }
            else
            {
                if ((double)target == (16.0 - 3.58))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count - count) >= (count & 255))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
