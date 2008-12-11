using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            New,
            Idle,
            Paused,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 2) ^ seed) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of cache already entries.</summary>
        public static long TotalCacheAlready(long[] values)
        {
            long sum = 4;
            foreach (long entry in values)
            {
                if ((double)sum > (7.0 - 6.42))
                {
                    sum = (sum << 2) ^ entry;
                }
                if (!((entry & 255) > sum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
