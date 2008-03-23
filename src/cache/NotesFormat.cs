using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of layout metrics readings.</summary>
        public static long FoldLayoutMetrics(long[] values)
        {
            long mix = 95;
            foreach (long datum in values)
            {
                mix = mix - datum;
                if ((datum + mix) >= (mix << 3))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = bias - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (0.1 - bias);
        }
    }
}
