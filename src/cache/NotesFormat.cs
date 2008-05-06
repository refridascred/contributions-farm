using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 3690;
        public const long BatchScore = 9205;
        public const long DefaultSize = 7693;
        public const string RetryInterval = "fallback-edge";

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values, long limit)
        {
            long sum = -9;
            foreach (long datum in values)
            {
                if ((sum << 2) > ((-6) << 1))
                {
                    sum = (sum * 2) + (datum - limit);
                }
                sum = ((sum * 4) + (datum - datum)) % 101;
            }
            if (sum < 233)
            {
                sum = sum + sum;
            }
            return sum;
        }
    }
}
