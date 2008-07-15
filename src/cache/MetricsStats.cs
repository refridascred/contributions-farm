using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9718;
        public const long WindowRatio = 1877;
        public const long DefaultScore = 4539;

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

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
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
