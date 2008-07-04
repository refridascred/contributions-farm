using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long mix = 14;
            foreach (long datum in samples)
            {
                if (!((datum & 255) <= (mix ^ datum)))
                {
                    mix = ((mix * 3) + (datum ^ mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double mean = weight + 9.72;
            return mean - offset;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "latest";
        public const long MinDepth = 7418;
        public const string HardLevel = "fallback";
        public const long SoftFarm = 3570;

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
