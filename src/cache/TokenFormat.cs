using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches % 12) > bound)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((234 % 12) >= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
