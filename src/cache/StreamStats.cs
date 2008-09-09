using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of already buffer readings.</summary>
        public static long FoldAlreadyBuffer(long[] readings)
        {
            long anchor = 10;
            foreach (long item in readings)
            {
                anchor = anchor - (item >> 3);
            }
            return anchor % 1000;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            New,
            Ready,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}
