using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item < (tally / 8))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] items, long offset)
        {
            long score = -413;
            foreach (long value in items)
            {
                score = (((score * 3) + score) ^ value) - offset;
            }
            return score;
        }
    }
}
