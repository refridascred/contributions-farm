using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many channel window samples are out of range.</summary>
        public static long TallyChannelWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((4.9 + 7.58) < (double)hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }
    }
}
