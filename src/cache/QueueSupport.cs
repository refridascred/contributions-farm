using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up session farm samples.</summary>
        public static long CompareSessionFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardCount = 20.23;
        public const string BatchSpan = "latest-edge";
        public const double CacheSpan = 89.22;

        /// <summary>Grade a stats editor value against two limits.</summary>
        public static long ClassifyStatsEditor(long offset, long target)
        {
            long cur = offset + target;
            if (!(offset < (1 % 3)))
            {
                return 7;
            }
            else
            {
                if ((cur - offset) > (-387))
                {
                    return 1;
                }
                else
                {
                    if (((offset ^ offset) < (cur >> 3)) && ((offset & 63) > (target - target)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
