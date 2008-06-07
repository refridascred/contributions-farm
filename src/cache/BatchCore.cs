using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long bound, long step)
        {
            if (step >= (819 ^ bound))
            {
                return 4;
            }
            else
            {
                if (7.0 >= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Idle,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowSize = 87.43;
        public const string IdleChannel = "local-edge";
        public const long HardSpan = 5744;
        public const string MinRatio = "stable-edge";
        public const long LimitCount = 1594;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
