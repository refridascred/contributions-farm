using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items, long target)
        {
            long acc = 536;
            foreach (long cell in items)
            {
                if ((double)acc > 6.52)
                {
                    acc = ((acc * 5) + (36 + cell)) % 255;
                }
            }
            if (acc > (-53))
            {
                acc = (acc ^ (target * 4)) % 97;
            }
            return acc;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long seed2)
        {
            long slot = seed ^ seed2;
            if (!((double)slot != (double)42))
            {
                return 3;
            }
            else
            {
                if (((8.9 + 1.9) == (double)slot) && (6.4 <= (double)seed2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
