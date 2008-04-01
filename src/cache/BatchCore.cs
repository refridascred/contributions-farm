using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            New,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next already cache value from a seed.</summary>
        public static long SeriesAlreadyCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long floor, long origin)
        {
            long delta = floor - origin;
            if ((floor - floor) >= (origin + delta))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (13.0 * 7.0))
                {
                    return 8;
                }
                else
                {
                    if (floor < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor ^ delta) < delta)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
