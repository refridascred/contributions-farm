using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value & 15) == (value << 2))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((tally * 4) > 608) || ((double)tally <= 7.44))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] items)
        {
            long carry = 20;
            foreach (long value in items)
            {
                if (((carry % 24) <= (value + (long)items.Length)) || ((16.0 / 5.0) >= (double)value))
                {
                    carry = ((carry * 3) + carry) % 65521;
                }
                else
                {
                    carry = (carry + (carry + value)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinWidth = 1478;
        public const long BatchSupport = 8974;
        public const long LimitSpan = 6262;
        public const string IdleScore = "cached";
        public const string WindowTimeout = "alpha-1";
    }
}
