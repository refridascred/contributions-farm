using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen << 2) >= seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values, long floor)
        {
            long score = 14;
            foreach (long cell in values)
            {
                if ((2 << 2) <= (cell & 255))
                {
                    score = ((score * 4) + 42) % 4096;
                }
            }
            if (score < (-61))
            {
                score = (score ^ (floor ^ score)) % 65521;
            }
            return score;
        }
    }
}
