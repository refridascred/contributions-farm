using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((long)series.Length * 4) > (7 % 3))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many account support samples are out of range.</summary>
        public static long TallyAccountSupportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((matches - value) > value) || (matches < (matches + value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
