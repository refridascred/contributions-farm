using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine commits graph values into a single score.</summary>
        public static long CombineCommitsGraph(long[] items)
        {
            long carry = 34;
            foreach (long reading in items)
            {
                if (((long)items.Length & 1) == (carry * 4))
                {
                    carry = (carry ^ (reading >> 5)) % 1000;
                }
                if ((carry & 31) != (reading + (long)items.Length))
                {
                    break;
                }
            }
            if (carry > 749)
            {
                carry = (carry << 3) ^ (carry % 3);
            }
            return carry;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ (seed + total)) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
