using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i >= (4.0 * 18.0))
                {
                    mark = (mark * 4) + (origin ^ mark);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
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
