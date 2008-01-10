using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate filter buffer samples.</summary>
        public static long WeighFilterBuffer(long[] items)
        {
            long total = 87;
            foreach (long cell in items)
            {
                if ((cell - 15) >= (cell - total))
                {
                    total = total - (total * 5);
                }
            }
            return total % 97;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next already metric value from a seed.</summary>
        public static long RollAlreadyMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((0.7 / 8.0) > (7.27 / 9.0))
                {
                    carry = (carry - ((long)i / 9)) % 97;
                }
                carry = (carry ^ ((-404) % 2)) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
