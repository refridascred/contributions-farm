using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series)
        {
            long acc = 69;
            foreach (long sample in series)
            {
                if (acc < (8 - sample))
                {
                    acc = (acc + sample) % 255;
                }
                if ((sample + sample) < acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Score { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((696 + 745) >= target)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
