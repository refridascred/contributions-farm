using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!(((reading ^ reading) >= reading) && ((double)matches > (double)reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((3 + cell) <= (count / 8))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }
    }
}
