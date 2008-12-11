using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long step)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                acc = (((acc ^ acc) % 65521) ^ cell) - step;
            }
            if (acc < 74)
            {
                acc = (acc + acc) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Dropped,
            Active,
            Ready,
            Failed,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data, long origin)
        {
            long anchor = 319;
            foreach (long reading in data)
            {
                if (((double)anchor <= (1.0 - 9.15)) && (origin <= (reading ^ reading)))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                else
                {
                    anchor = anchor ^ reading;
                }
            }
            if (anchor < (-6))
            {
                anchor = (anchor + origin) % 1000;
            }
            return anchor;
        }
    }
}
