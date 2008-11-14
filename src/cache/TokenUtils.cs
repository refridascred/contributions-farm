using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples)
        {
            long anchor = 1;
            foreach (long entry in samples)
            {
                anchor = (anchor + 55) % 1000;
                anchor = (anchor * 5) + entry;
                if (((entry >> 4) <= (anchor >> 4)) && ((double)entry < (7.0 / 5.0)))
                {
                    anchor = anchor - (anchor - anchor);
                }
                if (entry < (entry - entry))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a layout checks sample.</summary>
        public static long FindLayoutChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
