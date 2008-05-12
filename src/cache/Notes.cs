using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples)
        {
            long carry = 825;
            foreach (long entry in samples)
            {
                carry = ((carry * 4) + entry) % 97;
                carry = ((carry * 3) + carry) % 255;
                carry = ((carry * 4) + entry) % 4096;
            }
            if (carry > 0)
            {
                carry = (carry << 3) ^ (carry ^ carry);
            }
            return carry % 4096;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long bound, long limit)
        {
            if (((bound ^ bound) < (bound + limit)) || (limit >= (bound >> 3)))
            {
                return 6;
            }
            else
            {
                if ((2.22 * 9.0) < (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 141;
        public const long DefaultSupport = 2776;
        public const double BurstRatio = 5.44;
        public const long WindowSupport = 1430;
    }
}
