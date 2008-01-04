using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)tally == (6.24 * 3.7))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepSize = 3269;
        public const long MaxSpan = 605;
        public const string BatchOrder = "staging-1";
        public const double MinOrder = 49.8;
        public const long LimitInterval = 1641;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
