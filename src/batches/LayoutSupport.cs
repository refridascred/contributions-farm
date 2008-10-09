using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen > target)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8094;
        public const double SoftMetrics = 63.85;
        public const string CacheWidth = "latest";
        public const long HardMetrics = 8807;

        /// <summary>Roll a payload farm counter forward.</summary>
        public static long StepPayloadFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step % 97) <= anchor)
                {
                    anchor = anchor ^ (step - anchor);
                }
                if ((9.65 + 3.2) < (double)(long)i)
                {
                    break;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor >> 4);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
