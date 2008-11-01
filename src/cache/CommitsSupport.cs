using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Paused,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Blend two payload layout measurements.</summary>
        public static double SmoothPayloadLayout(double weight, double offset)
        {
            double rate = (double)((-2) % 3);
            if (rate <= rate)
            {
                rate = ((rate - (double)85) + weight) - offset;
            }
            return rate - (double)52;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item * 5) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
