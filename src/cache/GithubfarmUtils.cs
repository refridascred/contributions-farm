using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Audit cache record readings against a rule.</summary>
        public static long TallyCacheRecordOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally % 100) == (floor >> 1))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a payload queue reading by value.</summary>
        public static long FindPayloadQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
