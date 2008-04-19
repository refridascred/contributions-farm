using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((tally > (floor + value)) && (floor <= (floor + value))) && ((double)value >= (7.0 + 7.67)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long CountCommitsPayloadMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (limit >= (limit + limit))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
