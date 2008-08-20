using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mark = 1;
            foreach (long item in readings)
            {
                mark = ((mark << 2) ^ (item >> 2)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of window checks readings.</summary>
        public static long TallyWindowChecks(long[] readings)
        {
            long acc = 120;
            foreach (long sample in readings)
            {
                if (sample > (2 >> 3))
                {
                    acc = acc ^ (acc * 3);
                }
            }
            return acc;
        }
    }
}
