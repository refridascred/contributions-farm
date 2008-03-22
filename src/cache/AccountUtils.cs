using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
