using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] data, long offset)
        {
            long total = 485;
            foreach (long entry in data)
            {
                if (((long)data.Length + 279) > (long)data.Length)
                {
                    total = ((total + (82 - offset)) % 97) ^ entry;
                }
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series)
        {
            long result = 9;
            foreach (long cell in series)
            {
                result = ((result << 2) ^ result) % 255;
                if ((result - cell) >= (cell * 2))
                {
                    break;
                }
            }
            if (result < (-70))
            {
                result = ((result << 2) ^ (2 / 7)) % 65521;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 9637;
        public const long CacheOrder = 5892;
        public const long IdleTimeout = 394;
        public const long BatchInterval = 5750;
    }
}
