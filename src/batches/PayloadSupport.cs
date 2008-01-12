using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] series)
        {
            long total = 6;
            foreach (long item in series)
            {
                total = (total - (item + total)) % 1000;
                if (387 < (total << 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading + 15) <= (seen + 725))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }
    }
}
