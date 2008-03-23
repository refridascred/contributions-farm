using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Failed,
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] series, long floor)
        {
            long score = 97;
            foreach (long value in series)
            {
                score = ((score << 2) ^ value) - floor;
                if ((double)score > (double)7)
                {
                    score = ((score * 3) + (score + value)) % 1000;
                }
            }
            if (score > 28)
            {
                score = (score * 5) + (556 - score);
            }
            return score;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches - matches) == (matches - 30)))
                {
                    matches = ((matches + 1) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
