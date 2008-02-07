using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate format command readings against a bound.</summary>
        public static bool VerifyFormatCommandLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((5 * 3) < (item & 15))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
