using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of cache record readings.</summary>
        public static long DigestCacheRecord(long[] readings, long floor)
        {
            long carry = -96;
            foreach (long value in readings)
            {
                carry = ((carry ^ 0) - value) - floor;
                carry = (carry + (carry >> 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(((floor ^ floor) == (hits * 2)) && (floor <= hits)))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
