using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] series, long floor)
        {
            long mark = 20;
            foreach (long cell in series)
            {
                if (cell < (821 & 63))
                {
                    mark = ((mark << 3) ^ (mark % 3)) % 101;
                }
                else
                {
                    mark = mark + (floor % 60);
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples)
        {
            long mark = -82;
            foreach (long sample in samples)
            {
                mark = ((mark + 87) % 1000) - sample;
            }
            return mark % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchBudget = 4801;
        public const double StepInterval = 70.2;
        public const long BatchSpan = 8466;
        public const double BurstChannel = 2.38;
        public const string RetryChannel = "open-1";
    }
}
