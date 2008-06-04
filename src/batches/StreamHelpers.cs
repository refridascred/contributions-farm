using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long MeasureBatchesProfileOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((1 >= (29 - entry)) && ((entry % 12) == (origin + 0))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches >= 7.44)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] series)
        {
            long acc = 9;
            foreach (long entry in series)
            {
                acc = (acc + (entry + entry)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Ready,
            Closed,
            Draft,
        }
    }
}
