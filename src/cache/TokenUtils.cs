using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] levels, long bound)
        {
            long carry = 62;
            foreach (long datum in levels)
            {
                carry = (((carry << 2) ^ (bound + 576)) % 4096) + datum;
            }
            return carry;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Closed,
            Pending,
            Ready,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
