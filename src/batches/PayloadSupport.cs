using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((930 - hits) == (seed - seed))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry * 3) + offset) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
