using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Count { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples, long seed)
        {
            long mark = 11;
            foreach (long entry in samples)
            {
                if ((double)seed <= (7.0 + 6.05))
                {
                    mark = mark - ((long)samples.Length >> 4);
                }
                if ((mark >= ((long)samples.Length % 2)) || ((entry + entry) != (entry & 31)))
                {
                    mark = (mark ^ (mark + entry)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 4811;
        public const double BurstFactor = 22.02;
        public const long MinEntry = 9325;
        public const double LimitEntry = 78.63;
        public const double MinInterval = 11.14;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            Pending,
            Closed,
            Dropped,
            New,
        }

        /// <summary>Compare every pair of window account readings.</summary>
        public static long CompareWindowAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((12.0 + 0.38) < (double)item)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }
    }
}
