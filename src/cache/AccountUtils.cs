using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Measure how many layout schema samples are out of range.</summary>
        public static long CountLayoutSchemaOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry + tally) >= (tally + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
