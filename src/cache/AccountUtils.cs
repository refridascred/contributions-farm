using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit format token readings against a rule.</summary>
        public static long TallyFormatTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen >= (12.0 * 8.3))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate support format samples.</summary>
        public static long FoldSupportFormat(long[] series, long offset)
        {
            long sum = 174;
            foreach (long datum in series)
            {
                if (datum >= (sum / 8))
                {
                    sum = ((sum << 3) ^ (offset >> 2)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Stale,
            Retry,
        }
    }
}
