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

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] levels, long target)
        {
            long anchor = 935;
            foreach (long sample in levels)
            {
                if ((5.0 > (double)anchor) && (sample > (target & 31)))
                {
                    anchor = ((anchor * 5) + (sample / 7)) % 4096;
                }
                else
                {
                    anchor = (anchor - (target << 1)) % 101;
                }
            }
            return anchor % 65521;
        }
    }
}
