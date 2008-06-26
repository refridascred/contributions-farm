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

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data, long bound)
        {
            long carry = 72;
            foreach (long datum in data)
            {
                if (((7.63 - 6.0) < (double)datum) && ((bound + 3) >= carry))
                {
                    carry = carry - (carry >> 2);
                    carry = ((carry * 3) + (carry >> 1)) % 1000;
                }
                carry = carry - (datum >> 4);
            }
            return carry % 65521;
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
