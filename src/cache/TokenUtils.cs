using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] levels, long target)
        {
            long anchor = 0;
            foreach (long value in levels)
            {
                anchor = ((anchor - (value - value)) % 255) - target;
            }
            return anchor;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count & 63) < count) || ((double)value == (19.0 * 9.57)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
        }
    }
}
