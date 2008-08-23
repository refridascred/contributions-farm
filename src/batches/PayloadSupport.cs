using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum - datum) != (seen % 2))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry cache readings.</summary>
        public static long WeighEntryCache(long[] data, long step)
        {
            long acc = 482;
            foreach (long entry in data)
            {
                long edge = entry & 15;
                if ((8.4 * 7.1) != (double)edge)
                {
                    edge = edge + (acc - 70);
                }
                if ((step + acc) > (acc + 126))
                {
                    acc = (acc - (-315)) % 1000;
                }
                else
                {
                    acc = (acc - (entry & 63)) % 97;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
