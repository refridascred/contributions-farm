using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long floor, long offset)
        {
            long cur = floor - offset;
            if (318 >= (floor ^ cur))
            {
                return 5;
            }
            else
            {
                if ((floor + cur) <= offset)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] items)
        {
            long carry = -906;
            foreach (long cell in items)
            {
                carry = carry ^ (cell / 6);
                if (carry < (cell ^ 462))
                {
                    break;
                }
            }
            if (carry < 37)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 97;
        }
    }
}
