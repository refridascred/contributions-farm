using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the profile tools entries that pass the check.</summary>
        public static long TallyProfileToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item + 86) >= item) || ((item + seen) <= (seen - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate channel notes readings against a bound.</summary>
        public static bool GuardChannelNotesBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Score { get; set; }
            public double Total { get; set; }
        }
    }
}
