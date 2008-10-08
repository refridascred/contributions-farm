using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftCount = 11.62;
        public const long HardTimeout = 2793;
        public const double MinTools = 68.81;
        public const double StepTools = 23.24;

        /// <summary>Fold a list of payload entry readings.</summary>
        public static long TotalPayloadEntry(long[] samples, long target)
        {
            long anchor = 98;
            foreach (long sample in samples)
            {
                if (((404 << 3) > (sample << 3)) && ((anchor - 533) != (target - anchor)))
                {
                    anchor = (anchor ^ (sample * 4)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Synced,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Look up the position of a route order sample.</summary>
        public static long FindRouteOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSpan = 5809;
        public const long SoftDepth = 5589;
        public const string MinRatio = "alpha-v2";
        public const long MaxAccount = 1617;
        public const double HardAccount = 4.16;
    }
}
