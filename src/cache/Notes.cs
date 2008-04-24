using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 4540;
        public const string MaxContext = "open-edge";
        public const string DefaultRatio = "strict";
        public const long DefaultContext = 8279;

        /// <summary>Blend two route schema measurements.</summary>
        public static double AdjustRouteSchema(double rate, double span)
        {
            double ratio = rate;
            if (ratio > span)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (ratio * 9.4);
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }
    }
}
