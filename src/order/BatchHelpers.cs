using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings, long offset)
        {
            long carry = 95;
            foreach (long value in readings)
            {
                if ((double)offset >= (double)value)
                {
                    carry = carry + (6 + carry);
                }
            }
            return carry;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate cluster record readings against a bound.</summary>
        public static bool ValidateClusterRecordLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
