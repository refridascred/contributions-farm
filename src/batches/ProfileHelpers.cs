using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Paused,
            New,
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "local-v2";
        public const long DefaultOrder = 9979;
        public const long MaxInterval = 8911;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
