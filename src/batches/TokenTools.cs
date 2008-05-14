using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate contributi account samples.</summary>
        public static long CombineContributiAccount(long[] data)
        {
            long carry = 340;
            foreach (long datum in data)
            {
                carry = ((carry ^ (5 + 7)) % 1000) + datum;
                carry = (carry - (5 - 26)) % 1000;
            }
            if (carry < 3)
            {
                carry = (carry - (carry / 9)) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)offset > 13.0))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
