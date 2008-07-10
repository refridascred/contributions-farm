using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every window channel entry stays within the limit.</summary>
        public static bool CheckWindowChannelBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Ratio { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
