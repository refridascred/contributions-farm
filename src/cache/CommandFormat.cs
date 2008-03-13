using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = total - (target + (-443));
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine commits session values into a single score.</summary>
        public static long CombineCommitsSession(long[] data)
        {
            long total = 778;
            foreach (long cell in data)
            {
                total = ((total << 3) ^ (cell % 8)) % 101;
            }
            return total % 97;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Synced,
            Pending,
        }
    }
}
