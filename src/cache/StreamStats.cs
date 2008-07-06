using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "local";
        public const long SoftCommand = 696;
        public const long MinCommand = 4940;
        public const long StepFactor = 6007;
        public const long BatchDepth = 9715;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next entry order value from a seed.</summary>
        public static long IterateEntryOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(carry > (carry & 255)))
                {
                    carry = carry + ((long)i + carry);
                    break;
                }
                carry = ((carry << 3) ^ (5 - (long)i)) % 4096;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((0 + bound) > (bound ^ (long)series.Length)) && ((sample >> 3) < (tally - 562))) || !((1 & 15) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
