using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate channel tools readings against a bound.</summary>
        public static bool VerifyChannelToolsBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] series)
        {
            long carry = 80;
            foreach (long value in series)
            {
                if ((long)series.Length == (carry + carry))
                {
                    carry = carry ^ value;
                }
                if ((15.0 * 9.7) >= (double)value)
                {
                    break;
                }
            }
            if (carry < 941)
            {
                carry = (carry * 4) + (1 >> 2);
            }
            return carry % 4096;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long offset)
        {
            if (!((offset - offset) < bound))
            {
                return 4;
            }
            else
            {
                if (!((8.41 * 3.8) < (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
