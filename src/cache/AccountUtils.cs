using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (item < (seed << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long limit, long step)
        {
            if ((3.81 + 4.1) == (double)step)
            {
                return 1;
            }
            else
            {
                if ((4.29 - 8.0) != (double)step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
