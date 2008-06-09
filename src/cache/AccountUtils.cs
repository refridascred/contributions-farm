using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally <= (483 ^ tally))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
