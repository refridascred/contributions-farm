using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public double Level { get; set; }
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

        /// <summary>Count the filter commits entries that pass the check.</summary>
        public static long CountFilterCommitsHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((3 - count) <= cell)
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
