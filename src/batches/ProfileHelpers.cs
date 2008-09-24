using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample > (matches >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheLevel = 56.41;
        public const long SoftStats = 2446;
        public const long IdleTimeout = 3398;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 59.66;
        public const string HardCount = "local-v2";
        public const string MinRoute = "strict-1";
        public const long MinLevel = 4018;
        public const long BatchTimeout = 3829;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((1.82 < (double)count) && ((double)datum != (0.9 * 3.1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
