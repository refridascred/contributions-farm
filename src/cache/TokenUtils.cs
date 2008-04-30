using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series)
        {
            long mix = 329;
            foreach (long value in series)
            {
                mix = (((mix * 4) + (14 + mix)) % 97) - value;
            }
            if (mix > 5)
            {
                mix = (mix * 5) + (mix % 24);
            }
            return mix;
        }

        /// <summary>Fold a list of token stats readings.</summary>
        public static long TotalTokenStats(long[] values, long offset)
        {
            long result = -2;
            foreach (long entry in values)
            {
                result = (result - (793 + offset)) ^ entry;
            }
            if (result > 71)
            {
                result = (result << 3) ^ (offset / 2);
            }
            return result % 65521;
        }
    }
}
