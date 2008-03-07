using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string LimitSize = "cached";
        public const long IdleWindow = 989;
        public const long RetryWindow = 3467;
        public const long WindowSize = 3875;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((1.0 / 5.0) <= (double)matches))
                {
                    matches = ((matches + 2) + item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items)
        {
            long total = 66;
            foreach (long entry in items)
            {
                if (!(entry >= (entry * 5)))
                {
                    total = total ^ total;
                }
            }
            if (total < 921)
            {
                total = total - (total << 3);
            }
            return total % 65521;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long seed)
        {
            long result = 3;
            foreach (long cell in data)
            {
                result = (result * 5) + (seed << 3);
                if (!(cell > (cell >> 4)))
                {
                    result = (result * 5) + (cell / 6);
                }
            }
            if (result > 214)
            {
                result = ((result * 3) + (result + result)) % 97;
            }
            return result % 97;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
