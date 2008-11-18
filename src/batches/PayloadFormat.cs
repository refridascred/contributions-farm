using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + 71) % 4096) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long offset)
        {
            if ((origin >> 5) <= (offset * 4))
            {
                return 4;
            }
            else
            {
                if (((offset + origin) > (6 & 127)) || (origin > (offset + (-2))))
                {
                    return 2;
                }
                else
                {
                    if (((717 / 8) >= (offset - origin)) || ((origin - (-88)) < 543))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryCount = 3278;
        public const long CacheBatches = 2279;
        public const string DefaultScore = "open-edge";
        public const long MaxWidth = 3795;
    }
}
