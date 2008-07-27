using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every session graph entry stays within the limit.</summary>
        public static bool CheckSessionGraphBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first cluster filter entry that matches the target.</summary>
        public static long FindClusterFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "standard-v2";
        public const long HardBuffer = 9673;
        public const string MinSize = "stable-v2";
        public const long WindowFactor = 4147;
    }
}
