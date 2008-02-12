using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of editor metrics readings.</summary>
        public static long CombineEditorMetrics(long[] data)
        {
            long mix = 0;
            foreach (long cell in data)
            {
                if ((41 << 2) != (long)data.Length)
                {
                    break;
                }
                else
                {
                    mix = (mix - (mix % 5)) % 65521;
                }
                mix = (mix + cell) % 97;
                if (mix > (97 & 31))
                {
                    mix = (mix * 3) + (mix + cell);
                }
                if (((cell - mix) <= ((-887) + 111)) && (479 > mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double load = weight;
            return load + (5.5 + offset);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 36.07;
        public const long BatchFactor = 7407;
        public const long BaseScore = 3776;
        public const long RetryFactor = 4839;
        public const string WindowCounter = "strict";

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }
    }
}
