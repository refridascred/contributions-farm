using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings, long offset)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                if ((datum >> 1) == (datum & 31))
                {
                    anchor = ((anchor * 3) + (anchor - anchor)) + offset;
                }
                if (((datum - 218) == (5 / 2)) && ((15.0 / 8.0) < (double)datum))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 31.28;
        public const string BaseContributi = "legacy-1";
        public const double SoftContributi = 6.91;
        public const long BaseRatio = 9874;
    }
}
