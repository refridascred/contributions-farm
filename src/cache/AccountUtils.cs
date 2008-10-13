using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches >> 1) > (bound / 5))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
        }
    }
}
