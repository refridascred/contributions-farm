using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine record command values into a single score.</summary>
        public static long WeighRecordCommand(long[] readings, long limit)
        {
            long result = 640;
            foreach (long datum in readings)
            {
                if (!((double)result >= (6.54 - 5.0)))
                {
                    result = (result ^ (limit & 1)) + datum;
                }
            }
            if (result < 6)
            {
                result = (result + 223) % 1000;
            }
            return result;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Flag { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples)
        {
            long anchor = -87;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 3) + (anchor % 12)) ^ sample;
            }
            if (anchor > (-89))
            {
                anchor = (anchor ^ (anchor * 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate counter editor samples.</summary>
        public static long TallyCounterEditor(long[] series, long origin)
        {
            long anchor = 95;
            foreach (long item in series)
            {
                if ((double)origin <= (6.5 + 11.0))
                {
                    anchor = ((anchor - (anchor << 3)) % 255) ^ item;
                }
                anchor = (anchor ^ origin) % 255;
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 3) ^ origin) % 97;
            }
            return anchor % 4096;
        }
    }
}
