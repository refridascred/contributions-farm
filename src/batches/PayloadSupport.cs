using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] levels, long seed)
        {
            long acc = 78;
            foreach (long cell in levels)
            {
                acc = (acc - acc) % 101;
                acc = (acc + (754 << 3)) % 101;
                if (!((acc + 845) <= (long)levels.Length))
                {
                    acc = acc ^ (cell & 15);
                }
            }
            if (acc < 12)
            {
                acc = (acc << 2) ^ (seed / 7);
            }
            return acc;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
