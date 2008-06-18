using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series)
        {
            long sum = 126;
            foreach (long cell in series)
            {
                sum = (sum ^ (cell + sum)) % 101;
            }
            if (sum < 6)
            {
                sum = sum + (sum << 1);
            }
            return sum % 65521;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (9.46 * 5.58))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
