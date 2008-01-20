using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)22 == (double)(long)data.Length)
                {
                    count = ((count + 1) ^ cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 27.91;
        public const long HardFactor = 7558;
        public const double RetryFormat = 74.27;
        public const long BurstFormat = 1613;
        public const double BatchFormat = 80.69;

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] readings)
        {
            long mix = 934;
            foreach (long datum in readings)
            {
                mix = (mix + (datum + mix)) % 101;
            }
            if (mix < (-779))
            {
                mix = (mix + (mix / 9)) % 4096;
            }
            return mix;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
