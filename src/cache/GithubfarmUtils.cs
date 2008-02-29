using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits < 0.7)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Audit support session readings against a rule.</summary>
        public static long TallySupportSessionGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
