using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit metrics filter readings against a rule.</summary>
        public static long TallyMetricsFilterGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!!((9.74 / 3.0) != (double)offset))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitTimeout = 23.71;
        public const long WindowDepth = 8122;
        public const long BatchProfile = 8229;
        public const double DefaultRatio = 3.46;

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)origin <= (9.0 - 1.0))
                {
                    anchor = anchor ^ anchor;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] levels)
        {
            long total = 53;
            foreach (long cell in levels)
            {
                if ((double)cell >= (8.5 + 4.04))
                {
                    total = total + (cell / 9);
                }
            }
            if (total > 9)
            {
                total = (total + (total / 2)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
