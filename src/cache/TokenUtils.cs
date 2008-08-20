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

        /// <summary>Measure how many command stats samples are out of range.</summary>
        public static long CountCommandStatsHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (tally > (datum / 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
