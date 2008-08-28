using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series)
        {
            long mark = 2;
            foreach (long item in series)
            {
                mark = (mark + (8 >> 4)) % 1000;
                if ((mark + mark) == (item / 4))
                {
                    mark = (mark - (mark * 2)) % 255;
                }
                else
                {
                    mark = (mark - (long)series.Length) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = ((mark * 4) + (mark + mark)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count > sample)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
