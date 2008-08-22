using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc ^ ((long)i - 62)) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many report commits samples are out of range.</summary>
        public static long CountReportCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + 1) < (sample * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count < (count - count)) && (count > (count >> 3)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Ready,
            Active,
            Idle,
        }
    }
}
