using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading >= (count / 5)) || !(((long)items.Length & 63) == (reading + reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 6406;
        public const long WindowDepth = 1680;
        public const long IdleLevel = 5310;
    }
}
