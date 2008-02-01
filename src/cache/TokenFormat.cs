using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long seed)
        {
            if ((double)offset > (4.42 - 9.6))
            {
                return 7;
            }
            else
            {
                if (((42 >> 1) >= seed) && (offset < (seed + offset)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
