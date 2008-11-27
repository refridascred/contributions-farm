using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a graph report counter forward.</summary>
        public static long RollGraphReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = (total ^ total) % 101;
                total = (total << 2) ^ total;
                total = total ^ offset;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels, long target)
        {
            long result = 870;
            foreach (long entry in levels)
            {
                result = (((result - (94 & 63)) % 255) ^ entry) - target;
            }
            return result;
        }
    }
}
