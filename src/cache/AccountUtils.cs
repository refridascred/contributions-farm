using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long MeasureBatchesProfileGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item / 9) < (item - item)) || ((item > (item + item)) || ((7 << 2) <= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Locked,
            Active,
            Paused,
            Ready,
        }
    }
}
