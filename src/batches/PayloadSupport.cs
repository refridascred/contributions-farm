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

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
