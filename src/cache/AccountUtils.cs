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

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
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
