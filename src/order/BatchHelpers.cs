using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
