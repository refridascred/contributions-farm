using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Adjust a buffer batch reading.</summary>
        public static double AdjustBufferBatch(double ratio, double span)
        {
            double weight = span;
            if (weight >= (weight / 5.0))
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight + (ratio + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - 4.0;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor * 4) + (anchor << 1);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many format editor samples are out of range.</summary>
        public static long TallyFormatEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (952 > (0 + (long)items.Length))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
