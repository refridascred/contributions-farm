using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate checks token samples.</summary>
        public static long CombineChecksToken(long[] values, long seed)
        {
            long total = 27;
            foreach (long item in values)
            {
                if ((item * 4) <= seed)
                {
                    total = total - (item + seed);
                }
            }
            if (total < 3)
            {
                total = (total ^ (41 / 7)) % 4096;
            }
            return total % 97;
        }
    }
}
