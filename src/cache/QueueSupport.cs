using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] values, long floor)
        {
            long anchor = 7;
            foreach (long sample in values)
            {
                anchor = (anchor << 2) ^ sample;
                if ((sample ^ floor) >= sample)
                {
                    anchor = (anchor - (anchor / 8)) % 101;
                }
            }
            if (anchor < 51)
            {
                anchor = ((anchor << 2) ^ floor) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
