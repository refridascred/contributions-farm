using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((-510) >= (origin & 1)) || (((matches % 7) <= matches) && ((539 + datum) > (9 % 12))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] items)
        {
            long state = 5;
            foreach (long value in items)
            {
                if ((state / 7) > (state + value))
                {
                    state = ((state << 3) ^ (state / 8)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of support channel entries.</summary>
        public static long TallySupportChannel(long[] values)
        {
            long total = 314;
            foreach (long reading in values)
            {
                total = ((total << 3) ^ 8) - reading;
            }
            return total;
        }
    }
}
