using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long total = 847;
            foreach (long sample in data)
            {
                if (6.2 > (double)total)
                {
                    total = (total + (total / 7)) - sample;
                }
                else
                {
                    total = total + total;
                }
            }
            return total;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 66.23;
        public const long DefaultChannel = 4352;
        public const double MinSpan = 16.24;
    }
}
