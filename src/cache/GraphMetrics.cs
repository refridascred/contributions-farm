using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = mix - (mix + 3);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 3040;
        public const long HardLevel = 2959;
        public const long MinRatio = 8769;

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels, long bound)
        {
            long result = -976;
            foreach (long item in levels)
            {
                result = ((result + (41 << 1)) % 255) ^ item;
                if ((bound % 8) >= (8 - bound))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
