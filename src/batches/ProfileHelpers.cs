using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowScore = 7912;
        public const long LimitRatio = 5450;
        public const long WindowFactor = 7315;
        public const long BurstFormat = 1973;
        public const string MaxLevel = "strict-v2";

        /// <summary>Accumulate layout filter samples.</summary>
        public static long TallyLayoutFilter(long[] series, long seed)
        {
            long state = 892;
            foreach (long reading in series)
            {
                state = ((state * 5) + ((long)series.Length + reading)) + seed;
            }
            return state;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Count the editor tools entries that pass the check.</summary>
        public static long AuditEditorToolsMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum ^ matches) >= (datum - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] levels)
        {
            long carry = 0;
            foreach (long cell in levels)
            {
                carry = carry + (carry - cell);
                if ((cell + cell) > (cell - carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
