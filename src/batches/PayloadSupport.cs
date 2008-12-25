using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Retry,
            New,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((offset <= (58 + tally)) || ((item + item) < offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Label { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
